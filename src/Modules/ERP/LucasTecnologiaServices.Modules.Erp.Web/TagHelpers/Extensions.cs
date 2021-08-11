﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LucasTecnologiaServices.Modules.Erp.Web.TagHelpers
{
	public static class Extensions
	{
		public static void AddCssClass(this TagHelperOutput output, string cssClass)
		{
			var processed = false;
			if (output.Attributes.ContainsName("class"))
			{
				if (output.Attributes.TryGetAttribute("class", out TagHelperAttribute attribute))
				{
					if (attribute.Value != null && !String.IsNullOrWhiteSpace(attribute.Value.ToString()))
					{
						output.Attributes.SetAttribute("class", attribute.Value.ToString() + " " + cssClass);
						processed = true;
					}
				}
			}

			if (!processed)
			{
				output.Attributes.SetAttribute("class", cssClass);
			}
		}
		public static void AddCssClass(this TagHelperOutput output, List<string> cssClasses)
		{
			var processed = false;
			if (output.Attributes.ContainsName("class"))
			{
				if (output.Attributes.TryGetAttribute("class", out TagHelperAttribute attribute))
				{
					if (attribute.Value != null && !String.IsNullOrWhiteSpace(attribute.Value.ToString()))
					{
						output.Attributes.SetAttribute("class", attribute.Value.ToString() + " " + String.Join(" ", cssClasses));
						processed = true;
					}
				}
			}

			if (!processed)
			{
				output.Attributes.SetAttribute("class", String.Join(" ", cssClasses));
			}
		}
	}
}
