﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LucasTecnologiaServices.Modules.Erp.Api.Models
{
    public class FSResponse : BaseResponseModel
    {
        [JsonProperty(PropertyName = "object")]
        public FSResult Object { get; set; }

        public FSResponse()
        {
            base.Timestamp = DateTime.UtcNow;
            base.Success = true;
        }

        public FSResponse(FSResult result) : this()
        {
            Object = result;
        }
    }

    public class FSResult
    {
        [JsonProperty(PropertyName = "url")]
        public string Url { get; set; }

        [JsonProperty(PropertyName = "filename")]
        public string Filename { get; set; }
    }
}
