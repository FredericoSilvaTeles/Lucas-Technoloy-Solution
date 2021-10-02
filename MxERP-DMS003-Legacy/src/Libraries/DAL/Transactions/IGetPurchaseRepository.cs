// ReSharper disable All
using System;
using System.Collections.Generic;
using System.Dynamic;
using PetaPoco;
using MixERP.Net.Entities.Transactions;
namespace MixERP.Net.Schemas.Transactions.Data
{
    public interface IGetPurchaseRepository
    {

        DateTime DateFrom { get; set; }
        DateTime DateTo { get; set; }
        int OfficeId { get; set; }

        /// <summary>
        /// Prepares and executes IGetPurchaseRepository.
        /// </summary>
        decimal Execute();
    }
}