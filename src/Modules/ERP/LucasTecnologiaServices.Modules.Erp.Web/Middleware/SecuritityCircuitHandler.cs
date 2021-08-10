﻿using LucasTecnologiaServices.Modules.Erp.Api.Models;
using LucasTecnologiaServices.Modules.Erp.Database;
using LucasTecnologiaServices.Modules.Erp.Web.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace LucasTecnologiaServices.Modules.Erp.Web.Middleware
{
	public class SecuritityCircuitHandler : CircuitHandler
	{
		private AuthenticationStateProvider authStateProvider = null;

		private Dictionary<Circuit, Tuple<IDisposable, IDisposable>> contexts = new Dictionary<Circuit, Tuple<IDisposable, IDisposable>>();

		public SecuritityCircuitHandler(AuthenticationStateProvider authStateProvider)
		{
			this.authStateProvider = authStateProvider;
		}

		public override Task OnConnectionUpAsync(Circuit circuit, CancellationToken cancellationToken)
		{
			IDisposable dbCtx = DbContext.CreateContext(ErpSettings.ConnectionString);
			ErpUser user = AuthService.GetUser(authStateProvider.GetAuthenticationStateAsync().Result.User);
			IDisposable secCtx = user != null ? WebVella.Erp.Api.SecurityContext.OpenScope(user) : null;
			contexts.Add(circuit, new Tuple<IDisposable, IDisposable>(dbCtx, secCtx));
			return Task.CompletedTask;
		}

		public override Task OnConnectionDownAsync(Circuit circuit, CancellationToken cancellationToken)
		{
			if (contexts.ContainsKey(circuit))
			{
				Tuple<IDisposable, IDisposable> tuple = contexts[circuit];
				tuple.Item1.Dispose();
				tuple.Item2.Dispose();
				contexts.Remove(circuit);
			}
			return Task.CompletedTask;
		}

		public int ConnectedCircuits => contexts.Count;
	}
}
