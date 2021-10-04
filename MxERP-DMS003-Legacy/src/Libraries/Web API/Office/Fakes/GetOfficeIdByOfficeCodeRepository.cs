// ReSharper disable All
using System;
using System.Collections.Generic;
using MixERP.Net.Schemas.Office.Data;
using MixERP.Net.Entities.Office;

namespace MixERP.Net.Api.Office.Fakes
{
    public class GetOfficeIdByOfficeCodeRepository : IGetOfficeIdByOfficeCodeRepository
    {
        public string OfficeCode { get; set; }

        public int Execute()
        {
            return 1;
        }
    }
}