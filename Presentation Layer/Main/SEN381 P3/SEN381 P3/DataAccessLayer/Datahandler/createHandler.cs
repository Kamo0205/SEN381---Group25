using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace Data_Access_Layer.Datahandler
{
    class createHandler
    {
        public void CreateClient(string connection, Dictionary<string, dynamic> clientMap)
        {
            SqlConnection conn = new SqlConnection(connection);
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("spInsertClient", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", clientMap["id"]);
                cmd.Parameters.AddWithValue("@contractID", clientMap["contractID"]);
                cmd.Parameters.AddWithValue("@name", clientMap["name"]);
                cmd.Parameters.AddWithValue("@surname", clientMap["surname"]);
                cmd.Parameters.AddWithValue("@address", clientMap["address"]);
                cmd.Parameters.AddWithValue("@email", clientMap["email"]);
                cmd.Parameters.AddWithValue("@number", clientMap["number"]);
                cmd.ExecuteNonQuery();
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
        }

        public void CreateEmployee(string connection, Dictionary<string, dynamic> employeeMap)
        {
            SqlConnection conn = new SqlConnection(connection);
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("spInsertEmployee", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", employeeMap["id"]);
                cmd.Parameters.AddWithValue("@name", employeeMap["name"]);
                cmd.Parameters.AddWithValue("@surname", employeeMap["surname"]);
                cmd.Parameters.AddWithValue("@vatID", employeeMap["vatID"]);
                cmd.Parameters.AddWithValue("@email", employeeMap["email"]);
                cmd.Parameters.AddWithValue("@number", employeeMap["number"]);
                cmd.ExecuteNonQuery();
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
        }

        public void CreateContract(string connection, Dictionary<string, dynamic> contractMap)
        {
            SqlConnection conn = new SqlConnection(connection);
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("spInsertContract", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", contractMap["id"]);
                cmd.Parameters.AddWithValue("@serviceLevel", contractMap["serviceLevel"]);
                cmd.Parameters.AddWithValue("@experationDate", contractMap["experationDate"]);
                cmd.ExecuteNonQuery();
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
        }

        public void CreateEmployeeSkill(string connection, string empID, string skillID)
        {
            SqlConnection conn = new SqlConnection(connection);
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("spCreateEmployeeSkill", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@empID", empID);
                cmd.Parameters.AddWithValue("@skillID", skillID);
                cmd.ExecuteNonQuery();
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
        }

        public void CreateEquipment(string connection, Dictionary<string, dynamic> equipmentMap)
        {
            SqlConnection conn = new SqlConnection(connection);
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("spInsertEquipment", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", equipmentMap["id"]);
                cmd.Parameters.AddWithValue("@description", equipmentMap["description"]);
                cmd.ExecuteNonQuery();
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
        }

        public void CreateJob(string connection, Dictionary<string, dynamic> jobMap)
        {
            SqlConnection conn = new SqlConnection(connection);
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("spInsertJob", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", jobMap["id"]);
                cmd.Parameters.AddWithValue("@clientID", jobMap["clientID"]);
                cmd.Parameters.AddWithValue("@empID", jobMap["empID"]);
                cmd.Parameters.AddWithValue("@description", jobMap["description"]);
                cmd.Parameters.AddWithValue("@type", jobMap["type"]);
                cmd.Parameters.AddWithValue("@status", jobMap["status"]);
                cmd.ExecuteNonQuery();
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
        }

        public void CreateJobEquipment(string connection, string equipmentID, string jobID)
        {
            SqlConnection conn = new SqlConnection(connection);
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("spInsertJobEquipment", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@equipmentID", equipmentID);
                cmd.Parameters.AddWithValue("@jobID", jobID);
                cmd.ExecuteNonQuery();
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
        }

        public void CreateSkill(string connection, Dictionary<string, dynamic> skillMap)
        {
            SqlConnection conn = new SqlConnection(connection);
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("spInsertSkill", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", skillMap["id"]);
                cmd.Parameters.AddWithValue("@description", skillMap["description"]);
                cmd.Parameters.AddWithValue("@type", skillMap["type"]);
                cmd.ExecuteNonQuery();
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
        }
    }
}
