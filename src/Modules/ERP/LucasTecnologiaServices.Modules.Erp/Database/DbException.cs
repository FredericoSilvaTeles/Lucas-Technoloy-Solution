﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LucasTecnologiaServices.Modules.Erp.Database
{
	public class DbException : Exception
	{
		public DbException(string message) : base(message)
		{
		}
	}
}
