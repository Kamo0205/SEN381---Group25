﻿using Data_Access_Layer.Data_Models;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace Data_Access_Layer.Datahandler
{
    class CreateHandler
    {
        private SqlConnection conn;

        public CreateHandler(string connection)
        {
            this.conn = new SqlConnection(connection);
        }

        public void CreateClient(Client client)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("spInsertClient", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", client.Id);
                cmd.Parameters.AddWithValue("@contractID", client.Contract.ID);
                cmd.Parameters.AddWithValue("@name", client.FirstName);
                cmd.Parameters.AddWithValue("@surname", client.LastName);
                cmd.Parameters.AddWithValue("@address", client.Address);
                cmd.Parameters.AddWithValue("@email", client.Email);
                cmd.Parameters.AddWithValue("@number", client.PhoneNumber);
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

        public void CreateEmployee(Employee employee)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("spInsertEmployee", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", employee.Id);
                cmd.Parameters.AddWithValue("@name", employee.FirstName);
                cmd.Parameters.AddWithValue("@surname", employee.LastName);
                cmd.Parameters.AddWithValue("@vatID", employee.VatID);
                cmd.Parameters.AddWithValue("@email", employee.VatID);
                cmd.Parameters.AddWithValue("@number", employee.PhoneNumber);
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

        public void CreateContract(Contract contract)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("spInsertContract", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", contract.ID);
                cmd.Parameters.AddWithValue("@serviceLevel", contract.ServiceLevel);
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

        public void CreateEmployeeSkill(string empID, string skillID)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("spInsertEmployeeSkill", conn);
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

        public void CreateEquipment(Equipment equipment)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("spInsertEquipment", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", equipment.ID);
                cmd.Parameters.AddWithValue("@description", equipment.Description);
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

        public void CreateJob(Job job)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("spInsertJob", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", job.Id);
                cmd.Parameters.AddWithValue("@clientID", job.ClientId);
                cmd.Parameters.AddWithValue("@description", job.Description);
                cmd.Parameters.AddWithValue("@type", job.Type);
                cmd.Parameters.AddWithValue("@status", job.JobStatus);
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

        public void CreateJobEquipment(string equipmentID, string jobID)
        {
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

        public void CreateSkill(Skills skill)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("spInsertSkill", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", skill.ID);
                cmd.Parameters.AddWithValue("@description", skill.Description);
                cmd.Parameters.AddWithValue("@type", skill.Type);
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
