// ReSharper disable All
using MixERP.Net.DbFactory;
using MixERP.Net.Framework;
using MixERP.Net.Framework.Extensions;
using PetaPoco;
using MixERP.Net.Entities.Core;
using Npgsql;
using Serilog;
using System;
using System.Collections.Generic;
using System.Linq;
namespace MixERP.Net.Schemas.Core.Data
{
    /// <summary>
    /// Prepares, validates, and executes the function "core.get_state_id_by_state_code(_state_code character varying)" on the database.
    /// </summary>
    public class GetStateIdByStateCodeProcedure : DbAccess, IGetStateIdByStateCodeRepository
    {
        /// <summary>
        /// The schema of this PostgreSQL function.
        /// </summary>
        public override string _ObjectNamespace => "core";
        /// <summary>
        /// The schema unqualified name of this PostgreSQL function.
        /// </summary>
        public override string _ObjectName => "get_state_id_by_state_code";
        /// <summary>
        /// Login id of application user accessing this PostgreSQL function.
        /// </summary>
        public long _LoginId { get; set; }
        /// <summary>
        /// User id of application user accessing this table.
        /// </summary>
        public int _UserId { get; set; }
        /// <summary>
        /// The name of the database on which queries are being executed to.
        /// </summary>
        public string _Catalog { get; set; }

        /// <summary>
        /// Maps to "_state_code" argument of the function "core.get_state_id_by_state_code".
        /// </summary>
        public string StateCode { get; set; }

        /// <summary>
        /// Prepares, validates, and executes the function "core.get_state_id_by_state_code(_state_code character varying)" on the database.
        /// </summary>
        public GetStateIdByStateCodeProcedure()
        {
        }

        /// <summary>
        /// Prepares, validates, and executes the function "core.get_state_id_by_state_code(_state_code character varying)" on the database.
        /// </summary>
        /// <param name="stateCode">Enter argument value for "_state_code" parameter of the function "core.get_state_id_by_state_code".</param>
        public GetStateIdByStateCodeProcedure(string stateCode)
        {
            this.StateCode = stateCode;
        }
        /// <summary>
        /// Prepares and executes the function "core.get_state_id_by_state_code".
        /// </summary>
        /// <exception cref="UnauthorizedException">Thown when the application user does not have sufficient privilege to perform this action.</exception>
        public int Execute()
        {
            if (!this.SkipValidation)
            {
                if (!this.Validated)
                {
                    this.Validate(AccessTypeEnum.Execute, this._LoginId, this._Catalog, false);
                }
                if (!this.HasAccess)
                {
                    Log.Information("Access to the function \"GetStateIdByStateCodeProcedure\" was denied to the user with Login ID {LoginId}.", this._LoginId);
                    throw new UnauthorizedException("Access is denied.");
                }
            }
            string query = "SELECT * FROM core.get_state_id_by_state_code(@StateCode);";

            query = query.ReplaceWholeWord("@StateCode", "@0::character varying");


            List<object> parameters = new List<object>();
            parameters.Add(this.StateCode);

            return Factory.Scalar<int>(this._Catalog, query, parameters.ToArray());
        }


    }
}