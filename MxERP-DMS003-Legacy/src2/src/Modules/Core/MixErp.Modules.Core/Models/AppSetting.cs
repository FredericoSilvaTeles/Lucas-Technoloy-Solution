﻿using MixErp.Infrastructure.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MixErp.Modules.Core.Models
{
    public class AppSetting : EntityBaseWithTypedId<string>
    {
       public AppSetting(string id)
       {
           Id = Id;
       }
       
       [StringLength(450)]
        public string Value { get; set; }

        [StringLength(450)]
        public string Module { get; set; }

        public bool IsVisibleInCommonSettingPage { get; set; }
















    }
    














}
