using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseLayer
{
    public class DatabaseHandler
    {
        private SqlConnection conn;
        private string query;

        public DatabaseHandler()
        {
        }

        public object[] ReadClients()
        {
            return new object[] { };
        }

        public object[] ReadEmployees()
        {
            return new object[] { };
        }

        public object[] ReadJobs()
        {
            return new object[] { };
        }
    }
}
