using Data_Access_Layer.Data_Models;
using Data_Access_Layer.Datahandler;
using System.Collections;
using System.Data;
using System.Data.SqlClient;

namespace Data_Access_Layer
{
    //Data Source= Placholder
    public class DBAccess
    {
        SqlConnectionStringBuilder connection = new SqlConnectionStringBuilder();
        CreateHandler createDataHandler;
        DeleteHandler deleteDataHandler;
        ReadHandler readDataHandler;
        UpdateHandler updateDataHandler;


        public DBAccess()
        {
            connection.DataSource = @"DESKTOP-CU14BKP"; //the data source of the connection
            connection.InitialCatalog = @"SENGroup25DB"; //the inital catalog of the connection
            connection.IntegratedSecurity = true; //the integrated security of the connection

            createDataHandler = new CreateHandler(connection.ToString());
            deleteDataHandler = new DeleteHandler(connection.ToString());
            readDataHandler = new ReadHandler(connection.ToString());
            updateDataHandler = new UpdateHandler(connection.ToString());
        }

        public void CreateClient(Client client)
        {
            createDataHandler.CreateClient(client);
        }

        public void CreateEmployee(Employee employee)
        {
            createDataHandler.CreateEmployee(employee);
        }

        public void CreateContract(Contract contract)
        {
            createDataHandler.CreateContract(contract);
        }

        public void CreateEmployeeSkill(string empID, string skillID)
        {
            createDataHandler.CreateEmployeeSkill(empID, skillID);
        }

        public void CreateEquipment(Equipment equipment)
        {
            createDataHandler.CreateEquipment(equipment);
        }

        public void CreateJob(Job job)
        {
            createDataHandler.CreateJob(job);
        }

        public void CreateJobEquipment(string equipmentID, string jobID)
        {
            createDataHandler.CreateJobEquipment(equipmentID, jobID);
        }

        public void CreateSkill(Skills skill)
        {
            createDataHandler.CreateSkill(skill);
        }

        public void DeleteClient(string id)
        {
            deleteDataHandler.DeleteClient(id);
        }

        public void DeleteEmployee(string id)
        {
            deleteDataHandler.DeleteEmployee(id);
        }

        public void DeleteEquipment(string id)
        {
            deleteDataHandler.DeleteEquipment(id);
        }

        public void DeleteJob(string id)
        {
            deleteDataHandler.DeleteJob(id);
        }

        public void DeleteSkill(string id)
        {
            deleteDataHandler.DeleteSkill(id);
        }

        public DataTable GetClientByAddress(string address)
        {
            return readDataHandler.GetClientByAddress(address);
        }

        public DataTable GetClientByContactNumber(string number)
        {
            return readDataHandler.GetClientByContactNumber(number);
        }

        public DataTable GetClientByContractID(string id)
        {
            return readDataHandler.GetClientByContractID(id);
        }

        public DataTable GetClientByEmail(string email)
        {
            return readDataHandler.GetClientByEmail(email);
        }

        public DataTable GetClientByID(string id)
        {
            return readDataHandler.GetClientByID(id);
        }

        public DataTable GetContractByID(string id)
        {
            return readDataHandler.GetContractByID(id);
        }

        public DataTable GetEmployeeByContactNumber(string number)
        {
            return readDataHandler.GetEmployeeByContactNumber(number);
        }

        public DataTable GetEmployeeByEmail(string email)
        {
            return readDataHandler.GetEmployeeByEmail(email);
        }

        public DataTable GetEmployeeByID(string id)
        {
            return readDataHandler.GetEmployeeByID(id);
        }

        public DataTable GetEquipmentByID(string id)
        {
            return readDataHandler.GetEquipmentByID(id);
        }

        public DataTable GetJobByID(string id)
        {
            return readDataHandler.GetJobByID(id);
        }

        public DataTable GetSkillByID(string id)
        {
            return readDataHandler.GetSkillByID(id);
        }

        public DataTable GetSkillByType(string type)
        {
            return readDataHandler.GetSkillByType(type);
        }

        public void UpdateClient(Client client)
        {
            updateDataHandler.UpdateClient(client);
        }

        public void UpdateContract(Contract contract)
        {
            updateDataHandler.UpdateContract(contract);
        }

        public void UpdateEmployee(Employee employee)
        {
            updateDataHandler.UpdateEmployee(employee);
        }

        public void UpdateEquipment(Equipment equipment)
        {
            updateDataHandler.UpdateEquipment(equipment);
        }

        public void UpdateJob(Job job)
        {
            updateDataHandler.UpdateJob(job);
        }

        public void UpdateSkill(Skills skill)
        {
            updateDataHandler.UpdateSkill(skill);
        }
    }
}