﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LucasTecnologiaServices.Modules.Erp.Database.FieldTypes
{
    public class DbHtmlField : DbBaseField
    {
        [JsonProperty(PropertyName = "default_value")]
        public string DefaultValue { get; set; }
    }
}
