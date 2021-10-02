// ReSharper disable All
using System;
using System.Collections.Generic;
using System.Dynamic;
using PetaPoco;
using MixERP.Net.Entities.Transactions;
namespace MixERP.Net.Schemas.Transactions.Data
{
    public interface IPostPurchaseRepository
    {

        string BookName { get; set; }
        int OfficeId { get; set; }
        int UserId { get; set; }
        long LoginId { get; set; }
        DateTime ValueDate { get; set; }
        int CostCenterId { get; set; }
        string ReferenceNumber { get; set; }
        string StatementReference { get; set; }
        bool IsCredit { get; set; }
        string PartyCode { get; set; }
        int PriceTypeId { get; set; }
        int ShipperId { get; set; }
        int StoreId { get; set; }
        long[] TranIds { get; set; }
        MixERP.Net.Entities.Transactions.StockDetailType[] Details { get; set; }
        MixERP.Net.Entities.Core.AttachmentType[] Attachments { get; set; }

        /// <summary>
        /// Prepares and executes IPostPurchaseRepository.
        /// </summary>
        long Execute();
    }
}