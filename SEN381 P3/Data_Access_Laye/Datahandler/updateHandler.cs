using Data_Access_Layer.Data_Models;
using System.Data;
using System.Data.SqlClient;

namespace Data_Access_Layer.Datahandler
{
    class UpdateHandler
    {
        private SqlConnection conn;

        public UpdateHandler(string connection)
        {
            this.conn = new SqlConnection(connection);
        }

        public void UpdateClient(Client client)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("spUpdateClient", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", client.Id);
                cmd.Parameters.AddWithValue("@name", client.FirstName);
                cmd.Parameters.AddWithValue("@surname", client.LastName);
                cmd.Parameters.AddWithValue("@address", client.Address);
                cmd.Parameters.AddWithValue("@email", client.Email);
                cmd.Parameters.AddWithValue("@number", client.PhoneNumber);
                cmd.ExecuteNonQuery();
            }
            catch (SqlException e)
            {
                System.Console.WriteLine("UpdateHandler : UpdateClient ERROR:" + e.Message);
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

        public void UpdateContract(Contract contract)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("spUpdateContract", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", contract.Id);
                cmd.Parameters.AddWithValue("@serviceLevel", contract.ServiceLevel);
                cmd.Parameters.AddWithValue("@date", contract.ExperationDate);
                cmd.ExecuteNonQuery();
            }
            catch (SqlException e)
            {
                System.Console.WriteLine("UpdateHandler : UpdateContract ERROR:" + e.Message);
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

        public void UpdateEmployee(Employee employee, string password, string type)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("spUpdateEmployee", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", employee.Id);
                cmd.Parameters.AddWithValue("@name", employee.FirstName);
                cmd.Parameters.AddWithValue("@surname", employee.LastName);
                cmd.Parameters.AddWithValue("@password", password);
                cmd.Parameters.AddWithValue("@email", employee.Email);
                cmd.Parameters.AddWithValue("@number", employee.PhoneNumber);
                cmd.Parameters.AddWithValue("@type", type);
                cmd.ExecuteNonQuery();
            }
            catch (SqlException e)
            {
                System.Console.WriteLine("UpdateHandler : UpdateEmployee ERROR:" + e.Message);
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

        public void UpdateEquipment(Equipment equipment)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("spUpdateEquipment", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", equipment.ID);
                cmd.Parameters.AddWithValue("@description", equipment.Description);
                cmd.ExecuteNonQuery();
            }
            catch (SqlException e)
            {
                System.Console.WriteLine("UpdateHandler : UpdateEquipment ERROR:" + e.Message);
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

        public void UpdateJob(Job job)
        { 
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("spUpdateJob", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", job.Id);
                cmd.Parameters.AddWithValue("@description", job.JobDescription);
                cmd.Parameters.AddWithValue("@clientSatisfaction", job.ClientSatisfaction);
                cmd.Parameters.AddWithValue("@category", job.JobCategory);
                cmd.Parameters.AddWithValue("@type", job.JobType);
                cmd.ExecuteNonQuery();
            }
            catch (SqlException e)
            {
                System.Console.WriteLine("UpdateHandler : UpdateJob ERROR:" + e.Message);
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

        public void ReassignJob(string jobId, string employeeId)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("spReassignJob", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", jobId);
                cmd.Parameters.AddWithValue("@employeeID", employeeId);
                cmd.ExecuteNonQuery();
            }
            catch (SqlException e)
            {
                System.Console.WriteLine("UpdateHandler : ReassignJob ERROR:" + e.Message);
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

        public void UpdateJobStatus(Job job)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("spUpdateJobStatus", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", job.Id);
                cmd.Parameters.AddWithValue("@status", job.JobStatus);
                cmd.ExecuteNonQuery();
            }
            catch (SqlException e)
            {
                System.Console.WriteLine("UpdateHandler : UpdateJobStatus ERROR:" + e.Message);
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

        public void UpdateSkill(Skill skill)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("spUpdateJob", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", skill.ID);
                cmd.Parameters.AddWithValue("@description", skill.Description);
                cmd.Parameters.AddWithValue("@type", skill.Type);
                cmd.ExecuteNonQuery();
            }
            catch (SqlException e)
            {
                System.Console.WriteLine("UpdateHandler : UpdateSkill ERROR:" + e.Message);
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
