using Data_Access_Layer.Data_Models;
using System.Collections;
using System.Collections.Generic;
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
                cmd.Parameters.AddWithValue("@contractID", client.ContractID);
                cmd.Parameters.AddWithValue("@name", client.FirstName);
                cmd.Parameters.AddWithValue("@surname", client.LastName);
                cmd.Parameters.AddWithValue("@address", client.Address);
                cmd.Parameters.AddWithValue("@number", client.PhoneNumber);
                cmd.Parameters.AddWithValue("@email", client.Email);
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
                cmd.Parameters.AddWithValue("@id", contract.ID);
                cmd.Parameters.AddWithValue("@serviceLevel", contract.ServiceLevel);
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

        public void UpdateEmployee(Employee employee)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("spUpdateEmployee", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", employee.Id);
                cmd.Parameters.AddWithValue("@name", employee.FirstName);
                cmd.Parameters.AddWithValue("@surname", employee.LastName);
                cmd.Parameters.AddWithValue("@email", employee.Email);
                cmd.Parameters.AddWithValue("@number", employee.PhoneNumber);
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
                cmd.Parameters.AddWithValue("@clientID", job.ClientID);
                cmd.Parameters.AddWithValue("@type", job.JobType);
                cmd.Parameters.AddWithValue("@description", job.JobDescription);
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

        public void UpdateSkill(Skills skill)
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
