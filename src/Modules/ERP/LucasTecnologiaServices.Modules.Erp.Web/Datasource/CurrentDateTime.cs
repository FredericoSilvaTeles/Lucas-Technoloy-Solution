﻿using LucasTecnologiaServices.Modules.Erp.Api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LucasTecnologiaServices.Modules.Erp.Web.Datasource
{
	public class CurrentDateTime : CodeDataSource
	{
		public CurrentDateTime() : base()
{
			Id = new Guid("630F9600-EE23-4080-B718-698A9B368EED");
			Name = "CurrentDateTime";
			Description = "Provides current daytime plus simple calculations";
			ResultModel = "DateTime";

			//define custom meta
			//DataSourceModelFieldMeta dsMeta = new DataSourceModelFieldMeta();
			//dsMeta.EntityName = string.Empty;
			//dsMeta.Name = "CurrentDateTime";
			//dsMeta.Type = FieldType.DateTimeField;
			//Fields.Add(dsMeta);


			Parameters.Add(new DataSourceParameter { Name = "addYears", Type = "int", Value = "0" });
			Parameters.Add(new DataSourceParameter { Name = "addMonths", Type = "int", Value = "0" });
			Parameters.Add(new DataSourceParameter { Name = "addDays", Type = "int", Value = "0" });
			Parameters.Add(new DataSourceParameter { Name = "addHours", Type = "int", Value = "0" });
			Parameters.Add(new DataSourceParameter { Name = "addMinutes", Type = "int", Value = "0" });
			Parameters.Add(new DataSourceParameter { Name = "addSeconds", Type = "int", Value = "0" });

		}

		public override object Execute(Dictionary<string, object> arguments)
		{
			var nowDate = DateTime.Now;

			int addYears, addMonths, addDays, addHours, addMinutes, addSeconds;
			addYears = addMonths = addDays = addHours = addMinutes = addSeconds = 0;

			if (arguments.ContainsKey("addYears"))
				addYears = (int)arguments["addYears"];

			if (arguments.ContainsKey("addMonths"))
				addMonths = (int)arguments["addMonths"];

			if (arguments.ContainsKey("addDays"))
				addDays = (int)arguments["addDays"];

			if (arguments.ContainsKey("addHours"))
				addHours = (int)arguments["addHours"];

			if (arguments.ContainsKey("addMinutes"))
				addMinutes = (int)arguments["addMinutes"];

			if (arguments.ContainsKey("addSeconds"))
				addSeconds = (int)arguments["addSeconds"];

			return nowDate.AddYears(addYears).AddMonths(addMonths).AddDays(addDays).AddMinutes(addMinutes).AddSeconds(addSeconds);
		}
	}
}
