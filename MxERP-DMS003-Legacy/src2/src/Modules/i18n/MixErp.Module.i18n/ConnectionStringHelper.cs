using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MixErp.Module.i18n
{
    internal static class ConnectionStringHelper
    {
        public static string GetConnectionString()
        {
            string host = GetDbServerParameter("Server");
            string database = GetDbServerParameter("Database");
            string userId = GetDbServerParameter("userId");
            string password = GetDbServerParameter("password");
            int port = int.Parse(GetDbServerParameter("Port"));

            return GetConnectionString(host, database, userId, password, port);
        }

        private static string GetConnectionString(string host, string database, string userId, string password, int port)
        {
            throw new NotImplementedException();
        }

        private static string GetDbServerParameter(string keyname)
        {
            return GetConfigurationValue("DbServerConfiguration", keyname);
        }

        private static string GetConfigurationValue(string v, string keyname)
        {
            throw new NotImplementedException();
        }
    }
}
