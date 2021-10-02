﻿using System;
using SimplCommerce.Infrastructure.Models;
using SimplCommerce.Module.Core.Models;

namespace SimplCommerce.Module.Inventory.Models
{
    public class StockHistory : EntityBase
    {
        public long ProductId { get; set; }

        public long WareHouseId { get; set; }

        public DateTimeOffset CreatedOn { get; set; }

        public long CreatedById { get; set; }

        public User CreatedBy { get; set; }

        public long AdjustedQuantity { get; set; }

        public string Note { get; set; }
    }
}
