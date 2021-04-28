using System.Collections;
using System.Data;
using System.Data.SqlClient;

namespace Data_Access_Layer.Datahandler
{
    class readHandler
    {
        public DataTable GetClientByAddress(string connection, string address)
        {
            SqlConnection conn = new SqlConnection(connection);
            DataTable output = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter();
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("spGetClientByAddress", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@address", address);
                sda.SelectCommand = cmd;
                sda.FillSchema(output, SchemaType.Source);
                sda.Fill(output);
            }
            catch (SqlException e)
            {
                //TODO throw and catch exception
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }
            return output;
        }

        public DataTable GetClientByContactNumber(string connection, string number)
        {
            SqlConnection conn = new SqlConnection(connection);
            DataTable output = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter();
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("spGetClientByContactNumber", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@number", number);
                sda.SelectCommand = cmd;
                sda.FillSchema(output, SchemaType.Source);
                sda.Fill(output);
            }
            catch (SqlException e)
            {
                //TODO throw and catch exception
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }
            return output;
        }

        public DataTable GetClientByContractID(string connection, string id)
        {
            SqlConnection conn = new SqlConnection(connection);
            DataTable output = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter();
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("spGetClientByContractID", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", id);
                sda.SelectCommand = cmd;
                sda.FillSchema(output, SchemaType.Source);
                sda.Fill(output);
            }
            catch (SqlException e)
            {
                //TODO throw and catch exception
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }
            return output;
        }

        public DataTable GetClientByEmail(string connection, string email)
        {
            SqlConnection conn = new SqlConnection(connection);
            DataTable output = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter();
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("spGetClientByEmail", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@email", email);
                sda.SelectCommand = cmd;
                sda.FillSchema(output, SchemaType.Source);
                sda.Fill(output);
            }
            catch (SqlException e)
            {
                //TODO throw and catch exception
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }
            return output;
        }

        public DataTable GetClientByID(string connection, string id)
        {
            SqlConnection conn = new SqlConnection(connection);
            DataTable output = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter();
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("spGetClientByEmail", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", id);
                sda.SelectCommand = cmd;
                sda.FillSchema(output, SchemaType.Source);
                sda.Fill(output);
            }
            catch (SqlException e)
            {
                //TODO throw and catch exception
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }
            return output;
        }
    }
}
