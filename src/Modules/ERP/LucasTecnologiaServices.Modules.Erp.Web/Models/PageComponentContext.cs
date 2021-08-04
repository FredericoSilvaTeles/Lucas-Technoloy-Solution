﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LucasTecnologiaServices.Modules.Erp.Web.Models
{
	public class PageComponentContext
{
		public PageComponentContext(PageBodyNode node, PageDataModel dataModel = null, ComponentMode mode = ComponentMode.Display, JObject options = null, IDictionary<object, object> items = null)
		{
			Items = items ?? new Dictionary<object, object>();
			Node = node;
			Options = options;
			Mode = mode;
			DataModel = dataModel;
		}


		public IDictionary<object, object> Items { get; private set; }

		public PageBodyNode Node { get; private set; }

		public JObject Options { get; private set; }

		public ComponentMode Mode { get; private set; }

		public PageDataModel DataModel { get; private set; }

	}
}
