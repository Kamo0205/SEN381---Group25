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

        public DataTable ListContractsByClientID(string id)
        {
            DataTable output = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter();
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("spListContractsByClientID", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", id);
                sda.SelectCommand = cmd;
                sda.FillSchema(output, SchemaType.Source);
                sda.Fill(output);
            }
            catch (SqlException e)
            {
                System.Console.WriteLine("ReadHandler : ListContractsByClientID ERROR:" + e.Message);
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

        public DataTable ListEmployeesForJob(string category, string type)
        {
            DataTable output = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter();
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("spListEmployeesForJob", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@category", category);
                cmd.Parameters.AddWithValue("@type", type);
                sda.SelectCommand = cmd;
                sda.FillSchema(output, SchemaType.Source);
                sda.Fill(output);
            }
            catch (SqlException e)
            {
                System.Console.WriteLine("ReadHandler : ListEmployeesForJob ERROR:" + e.Message);
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

        public DataTable ListEmployees()
        {
            DataTable output = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter();
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM tblEmployee", conn);
                cmd.CommandType = CommandType.Text;
                sda.SelectCommand = cmd;
                sda.FillSchema(output, SchemaType.Source);
                sda.Fill(output);
            }
            catch (SqlException e)
            {
                System.Console.WriteLine("ReadHandler : ListEmployees ERROR:" + e.Message);
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
        public DataTable ListEmployeesByType()
        {
            DataTable output = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter();
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM tblAuthentication WHERE UserType = 'Technician' OR 'CallCentre'", conn);
                cmd.CommandType = CommandType.Text;
                sda.SelectCommand = cmd;
                sda.FillSchema(output, SchemaType.Source);
                sda.Fill(output);
            }
            catch (SqlException e)
            {
                System.Console.WriteLine("ReadHandler : ListEmployeesByType ERROR:" + e.Message);
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

        public DataTable ListEquipmentByJobId(string id)
        {
            DataTable output = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter();
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("spListEquipmentByJob", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@jobID", id);
                sda.SelectCommand = cmd;
                sda.FillSchema(output, SchemaType.Source);
                sda.Fill(output);
            }
            catch (SqlException e)
            {
                System.Console.WriteLine("ReadHandler : ListEquipmentByJobId ERROR:" + e.Message);
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

        public DataTable ListJobsByType(string type)
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
                System.Console.WriteLine("ReadHandler : ListJobsByType ERROR:" + e.Message);
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

        public DataTable ListJobsByCategory(string category)
        {
            DataTable output = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter();
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("spListJobsByCategory", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@category", category);
                sda.SelectCommand = cmd;
                sda.FillSchema(output, SchemaType.Source);
                sda.Fill(output);
            }
            catch (SqlException e)
            {
                System.Console.WriteLine("ReadHandler : ListJobsByCategory ERROR:" + e.Message);
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

        public DataTable ListJobsByContractID(string id)
        {
            DataTable output = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(); 
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("spListJobsByContractID", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", id);
                sda.SelectCommand = cmd;
                sda.FillSchema(output, SchemaType.Source);
                sda.Fill(output);
            }
            catch (SqlException e)
            {
                System.Console.WriteLine("ReadHandler : ListJobsByContractID ERROR:" + e.Message);
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

        public DataTable ListJobsByEmployeeID(string id)
        {
            DataTable output = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter();
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("spListJobsByEmpID", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", id);
                sda.SelectCommand = cmd;
                sda.FillSchema(output, SchemaType.Source);
                sda.Fill(output);
            }
            catch (SqlException e)
            {
                System.Console.WriteLine("ReadHandler : ListJobsByEmployeeID ERROR:" + e.Message);
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

        public DataTable ListJobsByStatus(string status)
        {
            DataTable output = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter();
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("spListJobsByStatus", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@status", status);
                sda.SelectCommand = cmd;
                sda.FillSchema(output, SchemaType.Source);
                sda.Fill(output);
            }
            catch (SqlException e)
            {
                System.Console.WriteLine("ReadHandler : ListJobsByStatus ERROR:" + e.Message);
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

        public DataTable ListSkillsByType(string type)
        {
            DataTable output = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter();
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("spListSkillsByType", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@type", type);
                sda.SelectCommand = cmd;
                sda.FillSchema(output, SchemaType.Source);
                sda.Fill(output);
            }
            catch (SqlException e)
            {
                System.Console.WriteLine("ReadHandler : ListSkillsByType ERROR:" + e.Message);
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

        public DataTable ListSkillsByCategory(string category)
        {
            DataTable output = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter();
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("spListSkillsByCategory", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@category", category);
                sda.SelectCommand = cmd;
                sda.FillSchema(output, SchemaType.Source);
                sda.Fill(output);
            }
            catch (SqlException e)
            {
                System.Console.WriteLine("ReadHandler : ListSkillsByCategory ERROR:" + e.Message);
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

        public DataTable ListSkillsByEmployeeID(string id)
        {
            DataTable output = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter();
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("spListSkillsByEmpID", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", id);
                sda.SelectCommand = cmd;
                sda.FillSchema(output, SchemaType.Source);
                sda.Fill(output);
            }
            catch (SqlException e)
            {
                System.Console.WriteLine("ReadHandler : ListSkillsByEmployeeID ERROR:" + e.Message);
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

        public DataTable Authenticate(string userName, string password)
        {
            DataTable output = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter();
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("spAuthenticate", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@userName", userName);
                cmd.Parameters.AddWithValue("@password", password);
                sda.SelectCommand = cmd;
                sda.FillSchema(output, SchemaType.Source);
                sda.Fill(output);
            }
            catch (SqlException e)
            {
                System.Console.WriteLine("ReadHandler : Authenticate ERROR:" + e.Message);
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
