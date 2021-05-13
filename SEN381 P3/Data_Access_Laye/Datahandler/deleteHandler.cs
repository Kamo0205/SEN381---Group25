using System.Data;
using System.Data.SqlClient;

namespace Data_Access_Layer.Datahandler
{
    class DeleteHandler
    {
        private SqlConnection conn;

        public DeleteHandler(string connection)
        {
            this.conn = new SqlConnection(connection);
        }

        public void DeleteClient(string id)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("spDeleteClient", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", id);
                cmd.ExecuteNonQuery();
            }
            catch (SqlException e)
            {
                System.Console.WriteLine("DeleteHandler : DeleteClient ERROR:" + e.Message);
                throw;
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }
        }

        public void DeleteEmployee(string id)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("spDeleteEmployee", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", id);
                cmd.ExecuteNonQuery();
            }
            catch (SqlException e)
            {
                System.Console.WriteLine("DeleteHandler : DeleteEmployee ERROR:" + e.Message);
                throw;
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }
        }

        public void DeleteEquipment(string id)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("spDeleteEquipment", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", id);
                cmd.ExecuteNonQuery();
            }
            catch (SqlException e)
            {
                System.Console.WriteLine("DeleteHandler : DeleteEquipment ERROR:" + e.Message);
                throw;
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }
        }

        public void DeleteJob(string id)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("spDeleteJob", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", id);
                cmd.ExecuteNonQuery();
            }
            catch (SqlException e)
            {
                System.Console.WriteLine("DeleteHandler : DeleteJob ERROR:" + e.Message);
                throw;
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }
        }

        public void DeleteSkill(string id)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("spDeleteSkill", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", id);
                cmd.ExecuteNonQuery();
            }
            catch (SqlException e)
            {
                System.Console.WriteLine("DeleteHandler : DeleteSkill ERROR:" + e.Message);
                throw;
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }
        }

        public void DeleteContract(string id)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("spDeleteContract", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", id);
                cmd.ExecuteNonQuery();
            }
            catch (SqlException e)
            {
                System.Console.WriteLine("DeleteHandler : DeleteContract ERROR:" + e.Message);
                throw;
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }
        }
    }
}
