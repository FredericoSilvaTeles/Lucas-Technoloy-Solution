﻿using LucasTecnologiaServices.Infrastructure.Models;
using LucasTecnologiaServices.Modules.Core.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LucasTecnologiaServices.Modules.Catalog.Models
{
    public class ProductPriceHistory : EntityBase
    {
        public ProductPriceHistory()
        {
            CreatedOn = DateTimeOffset.Now;
        }

        public Product Product { get; set; }

        public long CreatedById { get; set; }

        public User CreatedBy { get; set; }

        public DateTimeOffset CreatedOn { get; set; }

        public decimal? Price { get; set; }

        public decimal? OldPrice { get; set; }

        public decimal? SpecialPrice { get; set; }

        public DateTimeOffset? SpecialPriceStart { get; set; }

        public DateTimeOffset? SpecialPriceEnd { get; set; }

        [NotMapped]
        public bool IsPriceChange { get; set; }
    }
}
