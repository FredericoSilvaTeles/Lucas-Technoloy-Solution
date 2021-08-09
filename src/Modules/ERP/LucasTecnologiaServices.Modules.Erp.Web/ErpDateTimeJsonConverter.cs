﻿using Newtonsoft.Json.Converters;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LucasTecnologiaServices.Modules.Erp.Web
{
	public class ErpDateTimeJsonConverter : DateTimeConverterBase
	{
		private static TimeZoneInfo erpTimeZone;

		public ErpDateTimeJsonConverter()
		{
			erpTimeZone = TimeZoneInfo.FindSystemTimeZoneById(ErpSettings.TimeZoneName);
		}

		public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
		{
			var value = reader.Value;
			if (value == null)
				return null;
			DateTime dateTime = DateTime.Parse(value.ToString());
			switch (dateTime.Kind)
			{
				case DateTimeKind.Utc:
					return dateTime;
				case DateTimeKind.Local:
					return dateTime.ToUniversalTime();
				case DateTimeKind.Unspecified:
					return TimeZoneInfo.ConvertTimeToUtc(dateTime, erpTimeZone);
			}

			throw new Exception("ErpDateTimeJsonConverter: DateTimeKind type of parsed json date cannot be handled.");
		}

		public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
		{
			switch (((DateTime)value).Kind)
			{
				case DateTimeKind.Utc:
				case DateTimeKind.Local:
					{
						DateTime erpLocalDateTime = TimeZoneInfo.ConvertTimeBySystemTimeZoneId((DateTime)value, ErpSettings.TimeZoneName);
						erpLocalDateTime = DateTime.SpecifyKind(erpLocalDateTime, DateTimeKind.Unspecified);
						writer.WriteValue(erpLocalDateTime.ToString(ErpSettings.JsonDateTimeFormat));
					}
					break;
				case DateTimeKind.Unspecified:
					{
						writer.WriteValue(((DateTime)value).ToString(ErpSettings.JsonDateTimeFormat));
					}
					break;
			}
		}
	}
}
