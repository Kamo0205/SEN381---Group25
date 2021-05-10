using System.Collections;
using System.Data;
using System.Data.SqlClient;

namespace Data_Access_Layer
{
    //Data Source= Placholder
    public class DBAccess
    {
        SqlConnectionStringBuilder connection = new SqlConnectionStringBuilder();
        public DBAccess()
        {
            connection.DataSource = @"Placholder"; //the data source of the connection
            connection.InitialCatalog = @"Placholder"; //the inital catalog of the connection
            connection.IntegratedSecurity = true; //the integrated security of the connection
        }
    }
}