using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace Data_Access_Layer.Datahandler
{
    class updateHandler
    {
        public void UpdateClient(string connection, Dictionary<string, dynamic> clientMap)
        {
            SqlConnection conn = new SqlConnection(connection.ToString());
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("spUpdateClient", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", clientMap["id"]);
                cmd.Parameters.AddWithValue("@contractID", clientMap["contractID"]);
                cmd.Parameters.AddWithValue("@name", clientMap["name"]);
                cmd.Parameters.AddWithValue("@surname", clientMap["surname"]);
                cmd.Parameters.AddWithValue("@address", clientMap["address"]);
                cmd.Parameters.AddWithValue("@number", clientMap["number"]);
                cmd.Parameters.AddWithValue("@email", clientMap["email"]);
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

        public void UpdateContract(string connection, Dictionary<string, dynamic> contractMap)
        {
            SqlConnection conn = new SqlConnection(connection.ToString());
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("spUpdateContract", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", contractMap["id"]);
                cmd.Parameters.AddWithValue("@serviceLevel", contractMap["serviceLevel"]);
                cmd.Parameters.AddWithValue("@date", contractMap["date"]);
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

        public void UpdateEmployee(string connection, Dictionary<string, dynamic> employeeMap)
        {
            SqlConnection conn = new SqlConnection(connection.ToString());
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("spUpdateEmployee", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", employeeMap["id"]);
                cmd.Parameters.AddWithValue("@name", employeeMap["name"]);
                cmd.Parameters.AddWithValue("@surname", employeeMap["surname"]);
                cmd.Parameters.AddWithValue("@vat", employeeMap["vat"]);
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

        public void UpdateEquipment(string connection, Dictionary<string, dynamic> equipmentMap)
        {
            SqlConnection conn = new SqlConnection(connection.ToString());
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("spUpdateEquipment", conn);
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

        public void UpdateJob(string connection, Dictionary<string, dynamic> jobMap)
        {
            SqlConnection conn = new SqlConnection(connection.ToString());
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("spUpdateJob", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", jobMap["id"]);
                cmd.Parameters.AddWithValue("@clientID", jobMap["clientID"]);
                cmd.Parameters.AddWithValue("@type", jobMap["type"]);
                cmd.Parameters.AddWithValue("@description", jobMap["description"]);
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

        public void UpdateSkill(string connection, Dictionary<string, dynamic> skillMap)
        {
            SqlConnection conn = new SqlConnection(connection.ToString());
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("spUpdateJob", conn);
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
