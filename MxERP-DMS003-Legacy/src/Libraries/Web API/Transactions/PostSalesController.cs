// ReSharper disable All
using MixERP.Net.Framework;
using MixERP.Net.Entities.Transactions;
using MixERP.Net.Schemas.Transactions.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using MixERP.Net.ApplicationState.Cache;
using MixERP.Net.Common.Extensions;
using PetaPoco;
using MixERP.Net.EntityParser;
namespace MixERP.Net.Api.Transactions
{
    /// <summary>
    /// Provides a direct HTTP access to execute the function PostSales.
    /// </summary>
    [RoutePrefix("api/v1.5/transactions/procedures/post-sales")]
    public class PostSalesController : ApiController
    {
        /// <summary>
        /// Login id of application user accessing this API.
        /// </summary>
        public long _LoginId { get; set; }

        /// <summary>
        /// User id of application user accessing this API.
        /// </summary>
        public int _UserId { get; set; }

        /// <summary>
        /// Currently logged in office id of application user accessing this API.
        /// </summary>
        public int _OfficeId { get; set; }

        /// <summary>
        /// The name of the database where queries are being executed on.
        /// </summary>
        public string _Catalog { get; set; }

        /// <summary>
        ///     The PostSales repository.
        /// </summary>
        private readonly IPostSalesRepository repository;

        public class Annotation
        {
            public string BookName { get; set; }
            public int OfficeId { get; set; }
            public int UserId { get; set; }
            public long LoginId { get; set; }
            public DateTime ValueDate { get; set; }
            public int CostCenterId { get; set; }
            public string ReferenceNumber { get; set; }
            public string StatementReference { get; set; }
            public bool IsCredit { get; set; }
            public int PaymentTermId { get; set; }
            public string PartyCode { get; set; }
            public int PriceTypeId { get; set; }
            public int SalespersonId { get; set; }
            public int ShipperId { get; set; }
            public string ShippingAddressCode { get; set; }
            public int StoreId { get; set; }
            public bool IsNonTaxableSales { get; set; }
            public MixERP.Net.Entities.Transactions.StockDetailType[] Details { get; set; }
            public MixERP.Net.Entities.Core.AttachmentType[] Attachments { get; set; }
            public long[] NonGlTranIds { get; set; }
        }


        public PostSalesController()
        {
            this._LoginId = AppUsers.GetCurrent().View.LoginId.ToLong();
            this._UserId = AppUsers.GetCurrent().View.UserId.ToInt();
            this._OfficeId = AppUsers.GetCurrent().View.OfficeId.ToInt();
            this._Catalog = AppUsers.GetCurrentUserDB();

            this.repository = new PostSalesProcedure
            {
                _Catalog = this._Catalog,
                _LoginId = this._LoginId,
                _UserId = this._UserId
            };
        }

        public PostSalesController(IPostSalesRepository repository, string catalog, LoginView view)
        {
            this._LoginId = view.LoginId.ToLong();
            this._UserId = view.UserId.ToInt();
            this._OfficeId = view.OfficeId.ToInt();
            this._Catalog = catalog;

            this.repository = repository;
        }

        /// <summary>
        ///     Creates meta information of "post sales" annotation.
        /// </summary>
        /// <returns>Returns the "post sales" annotation meta information to perform CRUD operation.</returns>
        [AcceptVerbs("GET", "HEAD")]
        [Route("annotation")]
        [Route("~/api/transactions/procedures/post-sales/annotation")]
        public EntityView GetAnnotation()
        {
            if (this._LoginId == 0)
            {
                return new EntityView();
            }
            return new EntityView
            {
                Columns = new List<EntityColumn>()
                                {
                                        new EntityColumn { ColumnName = "_book_name",  PropertyName = "BookName",  DataType = "string",  DbDataType = "character varying",  IsNullable = false,  IsPrimaryKey = false,  IsSerial = false,  Value = "",  MaxLength = 0 },
                                        new EntityColumn { ColumnName = "_office_id",  PropertyName = "OfficeId",  DataType = "int",  DbDataType = "integer",  IsNullable = false,  IsPrimaryKey = false,  IsSerial = false,  Value = "",  MaxLength = 0 },
                                        new EntityColumn { ColumnName = "_user_id",  PropertyName = "UserId",  DataType = "int",  DbDataType = "integer",  IsNullable = false,  IsPrimaryKey = false,  IsSerial = false,  Value = "",  MaxLength = 0 },
                                        new EntityColumn { ColumnName = "_login_id",  PropertyName = "LoginId",  DataType = "long",  DbDataType = "bigint",  IsNullable = false,  IsPrimaryKey = false,  IsSerial = false,  Value = "",  MaxLength = 0 },
                                        new EntityColumn { ColumnName = "_value_date",  PropertyName = "ValueDate",  DataType = "DateTime",  DbDataType = "date",  IsNullable = false,  IsPrimaryKey = false,  IsSerial = false,  Value = "",  MaxLength = 0 },
                                        new EntityColumn { ColumnName = "_cost_center_id",  PropertyName = "CostCenterId",  DataType = "int",  DbDataType = "integer",  IsNullable = false,  IsPrimaryKey = false,  IsSerial = false,  Value = "",  MaxLength = 0 },
                                        new EntityColumn { ColumnName = "_reference_number",  PropertyName = "ReferenceNumber",  DataType = "string",  DbDataType = "character varying",  IsNullable = false,  IsPrimaryKey = false,  IsSerial = false,  Value = "",  MaxLength = 0 },
                                        new EntityColumn { ColumnName = "_statement_reference",  PropertyName = "StatementReference",  DataType = "string",  DbDataType = "text",  IsNullable = false,  IsPrimaryKey = false,  IsSerial = false,  Value = "",  MaxLength = 0 },
                                        new EntityColumn { ColumnName = "_is_credit",  PropertyName = "IsCredit",  DataType = "bool",  DbDataType = "boolean",  IsNullable = false,  IsPrimaryKey = false,  IsSerial = false,  Value = "",  MaxLength = 0 },
                                        new EntityColumn { ColumnName = "_payment_term_id",  PropertyName = "PaymentTermId",  DataType = "int",  DbDataType = "integer",  IsNullable = false,  IsPrimaryKey = false,  IsSerial = false,  Value = "",  MaxLength = 0 },
                                        new EntityColumn { ColumnName = "_party_code",  PropertyName = "PartyCode",  DataType = "string",  DbDataType = "character varying",  IsNullable = false,  IsPrimaryKey = false,  IsSerial = false,  Value = "",  MaxLength = 0 },
                                        new EntityColumn { ColumnName = "_price_type_id",  PropertyName = "PriceTypeId",  DataType = "int",  DbDataType = "integer",  IsNullable = false,  IsPrimaryKey = false,  IsSerial = false,  Value = "",  MaxLength = 0 },
                                        new EntityColumn { ColumnName = "_salesperson_id",  PropertyName = "SalespersonId",  DataType = "int",  DbDataType = "integer",  IsNullable = false,  IsPrimaryKey = false,  IsSerial = false,  Value = "",  MaxLength = 0 },
                                        new EntityColumn { ColumnName = "_shipper_id",  PropertyName = "ShipperId",  DataType = "int",  DbDataType = "integer",  IsNullable = false,  IsPrimaryKey = false,  IsSerial = false,  Value = "",  MaxLength = 0 },
                                        new EntityColumn { ColumnName = "_shipping_address_code",  PropertyName = "ShippingAddressCode",  DataType = "string",  DbDataType = "character varying",  IsNullable = false,  IsPrimaryKey = false,  IsSerial = false,  Value = "",  MaxLength = 0 },
                                        new EntityColumn { ColumnName = "_store_id",  PropertyName = "StoreId",  DataType = "int",  DbDataType = "integer",  IsNullable = false,  IsPrimaryKey = false,  IsSerial = false,  Value = "",  MaxLength = 0 },
                                        new EntityColumn { ColumnName = "_is_non_taxable_sales",  PropertyName = "IsNonTaxableSales",  DataType = "bool",  DbDataType = "boolean",  IsNullable = false,  IsPrimaryKey = false,  IsSerial = false,  Value = "",  MaxLength = 0 },
                                        new EntityColumn { ColumnName = "_details",  PropertyName = "Details",  DataType = "MixERP.Net.Entities.Transactions.StockDetailType",  DbDataType = "transactions.stock_detail_type[]",  IsNullable = false,  IsPrimaryKey = false,  IsSerial = false,  Value = "",  MaxLength = 0 },
                                        new EntityColumn { ColumnName = "_attachments",  PropertyName = "Attachments",  DataType = "MixERP.Net.Entities.Core.AttachmentType",  DbDataType = "core.attachment_type[]",  IsNullable = false,  IsPrimaryKey = false,  IsSerial = false,  Value = "",  MaxLength = 0 },
                                        new EntityColumn { ColumnName = "_non_gl_tran_ids",  PropertyName = "NonGlTranIds",  DataType = "long",  DbDataType = "bigint[]",  IsNullable = false,  IsPrimaryKey = false,  IsSerial = false,  Value = "",  MaxLength = 0 }
                                }
            };
        }




        [AcceptVerbs("POST")]
        [Route("execute")]
        [Route("~/api/transactions/procedures/post-sales/execute")]
        public long Execute([FromBody] Annotation annotation)
        {
            try
            {
                this.repository.BookName = annotation.BookName;
                this.repository.OfficeId = annotation.OfficeId;
                this.repository.UserId = annotation.UserId;
                this.repository.LoginId = annotation.LoginId;
                this.repository.ValueDate = annotation.ValueDate;
                this.repository.CostCenterId = annotation.CostCenterId;
                this.repository.ReferenceNumber = annotation.ReferenceNumber;
                this.repository.StatementReference = annotation.StatementReference;
                this.repository.IsCredit = annotation.IsCredit;
                this.repository.PaymentTermId = annotation.PaymentTermId;
                this.repository.PartyCode = annotation.PartyCode;
                this.repository.PriceTypeId = annotation.PriceTypeId;
                this.repository.SalespersonId = annotation.SalespersonId;
                this.repository.ShipperId = annotation.ShipperId;
                this.repository.ShippingAddressCode = annotation.ShippingAddressCode;
                this.repository.StoreId = annotation.StoreId;
                this.repository.IsNonTaxableSales = annotation.IsNonTaxableSales;
                this.repository.Details = annotation.Details;
                this.repository.Attachments = annotation.Attachments;
                this.repository.NonGlTranIds = annotation.NonGlTranIds;


                return this.repository.Execute();
            }
            catch (UnauthorizedException)
            {
                throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.Forbidden));
            }
            catch (MixERPException ex)
            {
                throw new HttpResponseException(new HttpResponseMessage
                {
                    Content = new StringContent(ex.Message),
                    StatusCode = HttpStatusCode.InternalServerError
                });
            }
            catch
            {
                throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.InternalServerError));
            }
        }
    }
}