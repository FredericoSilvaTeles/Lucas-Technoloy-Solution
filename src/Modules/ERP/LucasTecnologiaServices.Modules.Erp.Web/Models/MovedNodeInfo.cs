﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LucasTecnologiaServices.Modules.Erp.Web.Models
{
	public class MovedNodeInfo
	{
		[JsonProperty(PropertyName = "originContainerId")]
		public string OriginContainerId { get; set; } = "";

		[JsonProperty(PropertyName = "originParentNodeId")]
		public Guid? OriginParentNodeId { get; set; } = null;

		[JsonProperty(PropertyName = "originIndex")]
		public int originIndex { get; set; } = 0;

		[JsonProperty(PropertyName = "newContainerId")]
		public string NewContainerId { get; set; } = "";

		[JsonProperty(PropertyName = "newParentNodeId")]
		public Guid? NewParentNodeId { get; set; } = null;

		[JsonProperty(PropertyName = "newIndex")]
		public int NewIndex { get; set; } = 0;
	}
}
