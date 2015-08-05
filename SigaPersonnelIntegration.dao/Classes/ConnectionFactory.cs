using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SigaPersonnelIntegration.dao.Classes
{
    public class ConnectionFactory
    {
        private static OracleConnection connection = null;

        public static OracleConnection GetConnection()
        {
            if(connection == null)
            {
                connection = new OracleConnection();
                connection.ConnectionString = GetConnectionString();
            }
            return connection;
        }

        static private string GetConnectionString()
        {
            return "User Id=sigausr; password=sigatmp;Data Source=10.20.84.40:1521/sigatst; Pooling=false;";
        }
    }
}
