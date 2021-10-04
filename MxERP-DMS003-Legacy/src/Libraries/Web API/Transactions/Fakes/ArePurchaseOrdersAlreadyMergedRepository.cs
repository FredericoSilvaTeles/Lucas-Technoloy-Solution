// ReSharper disable All
using System;
using System.Collections.Generic;
using MixERP.Net.Schemas.Transactions.Data;
using MixERP.Net.Entities.Transactions;

namespace MixERP.Net.Api.Transactions.Fakes
{
    public class ArePurchaseOrdersAlreadyMergedRepository : IArePurchaseOrdersAlreadyMergedRepository
    {
        public long[] Arr { get; set; }

        public bool Execute()
        {
            return new bool();
        }
    }
}