using System.Collections;
using System.Data;
using System.Data.SqlClient;

namespace Data_Access_Layer.Datahandler
{
    class ReadHandler
    {
        private SqlConnection conn;

        public ReadHandler(string connection)
        {
            this.conn = new SqlConnection(connection);
        }

        public DataTable GetClientByAddress(string address)
        {
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
                System.Console.WriteLine("ReadHandler : GetClientByAddress ERROR:" + e.Message);
                throw;
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

        public DataTable GetClientByContactNumber(string number)
        {
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
                System.Console.WriteLine("ReadHandler : GetClientByContactNumber ERROR:" + e.Message);
                throw;
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

        public DataTable GetClientByContractID(string id)
        {
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
                System.Console.WriteLine("ReadHandler : GetClientByContractID ERROR:" + e.Message);
                throw;
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

        public DataTable GetClientByEmail(string email)
        {
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
                System.Console.WriteLine("ReadHandler : GetClientByEmail ERROR:" + e.Message);
                throw;
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

        public DataTable GetClientByID(string id)
        {
            DataTable output = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter();
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("spGetClientByID", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", id);
                sda.SelectCommand = cmd;
                sda.FillSchema(output, SchemaType.Source);
                sda.Fill(output);
            }
            catch (SqlException e)
            {
                System.Console.WriteLine("ReadHandler : GetClientByID ERROR:" + e.Message);
                throw;
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

        public DataTable GetContractByID(string id)
        {
            DataTable output = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter();
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("spGetContractByID", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", id);
                sda.SelectCommand = cmd;
                sda.FillSchema(output, SchemaType.Source);
                sda.Fill(output);
            }
            catch (SqlException e)
            {
                System.Console.WriteLine("ReadHandler : GetContractByID ERROR:" + e.Message);
                throw;
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

        public DataTable GetEmployeeByContactNumber(string number)
        {
            DataTable output = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter();
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("spGetEmpByContactNumber", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@number", number);
                sda.SelectCommand = cmd;
                sda.FillSchema(output, SchemaType.Source);
                sda.Fill(output);
            }
            catch (SqlException e)
            {
                System.Console.WriteLine("ReadHandler : GetEmployeeByContactNumber ERROR:" + e.Message);
                throw;
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

        public DataTable GetEmployeeByEmail(string email)
        {
            DataTable output = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter();
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("spGetEmpByEmail", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@email", email);
                sda.SelectCommand = cmd;
                sda.FillSchema(output, SchemaType.Source);
                sda.Fill(output);
            }
            catch (SqlException e)
            {
                System.Console.WriteLine("ReadHandler : GetEmployeeByEmail ERROR:" + e.Message);
                throw;
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

        public DataTable GetEmployeeByID(string id)
        {
            DataTable output = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter();
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("spGetEmpByEmail", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", id);
                sda.SelectCommand = cmd;
                sda.FillSchema(output, SchemaType.Source);
                sda.Fill(output);
            }
            catch (SqlException e)
            {
                System.Console.WriteLine("ReadHandler : GetEmployeeByID ERROR:" + e.Message);
                throw;
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

        public DataTable GetEquipmentByID(string id)
        {
            DataTable output = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter();
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("spGetEquipmentByID", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", id);
                sda.SelectCommand = cmd;
                sda.FillSchema(output, SchemaType.Source);
                sda.Fill(output);
            }
            catch (SqlException e)
            {
                System.Console.WriteLine("ReadHandler : GetEquipmentByID ERROR:" + e.Message);
                throw;
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

        public DataTable GetJobByID(string id)
        {
            DataTable output = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter();
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("spGetJobByID", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", id);
                sda.SelectCommand = cmd;
                sda.FillSchema(output, SchemaType.Source);
                sda.Fill(output);
            }
            catch (SqlException e)
            {
                System.Console.WriteLine("ReadHandler : GetJobByID ERROR:" + e.Message);
                throw;
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

        public DataTable GetJobByType(string type)
        {
            DataTable output = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter();
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("spListJobsByType", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@type", type);
                sda.SelectCommand = cmd;
                sda.FillSchema(output, SchemaType.Source);
                sda.Fill(output);
            }
            catch (SqlException e)
            {
                System.Console.WriteLine("ReadHandler : GetJobByType ERROR:" + e.Message);
                throw;
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

        public DataTable GetSkillByID(string id)
        {
            DataTable output = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter();
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("spGetSkillByID", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", id);
                sda.SelectCommand = cmd;
                sda.FillSchema(output, SchemaType.Source);
                sda.Fill(output);
            }
            catch (SqlException e)
            {
                System.Console.WriteLine("ReadHandler : GetSkillByID ERROR:" + e.Message);
                throw;
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

        public DataTable GetSkillByType(string type)
        {
            DataTable output = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter();
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("spGetSkillByType", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@type", type);
                sda.SelectCommand = cmd;
                sda.FillSchema(output, SchemaType.Source);
                sda.Fill(output);
            }
            catch (SqlException e)
            {
                System.Console.WriteLine("ReadHandler : GetSkillByType ERROR:" + e.Message);
                throw;
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
