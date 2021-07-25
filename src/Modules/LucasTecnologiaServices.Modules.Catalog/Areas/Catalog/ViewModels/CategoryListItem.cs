﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LucasTecnologiaServices.Modules.Catalog.Areas.Catalog.ViewModels
{
    public class CategoryListItem
    {
        public long Id { get; set; }

        public string Name { get; set; }

        public int DisplayOrder { get; set; }

        public bool IncludeInMenu { get; set; }

        public bool IsPublished { get; set; }

        public long? ParentId { get; set; }
    }
}
