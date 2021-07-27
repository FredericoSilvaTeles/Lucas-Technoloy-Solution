﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LucasTecnologiaServices.Modules.Erp.Api.Models.AutoMapper.Profiles
{
    internal class ErpRoleConverter : ITypeConverter<EntityRecord, ErpRole>
    {
        public ErpRole Convert(EntityRecord source, ErpRole destination, ResolutionContext context)
        {
            var src = source;

            if (src == null)
                return null;

            ErpRole dest = new ErpRole();
            dest.Id = (Guid)src["id"];
            dest.Name = (string)src["name"];
            dest.Description = (string)src["description"];
            return dest;
        }
    }
}
