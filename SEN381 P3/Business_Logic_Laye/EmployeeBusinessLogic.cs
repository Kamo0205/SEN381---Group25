using Data_Access_Layer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Business_Logic_Layer
{
    public enum employeeType
    {
        admin,
        callCenter,
        technician
    }
    public enum employeeSearchParamaters{
        id,
        email,
        phone
    }

    public enum employeeSkillCategories
    {
        software,
        hardware
    }

    public enum employeeSkillsTypes
    {
        installation,
        repair
    }

    public class EmployeeBusinessLogic
    {
        DBAccess db = new DBAccess();

        List<Employee> employees = new List<Employee>();

        public void deleteEmployee(string id)
        {
            try
            {
                db.DeleteEmployee(id);
            }
            catch (Exception e)
            {
                MessageBox.Show("EmployeeBusinessLogic : deleteEmployee ERROR:" + e.Message);
                throw;
            }
        }

        public void updateEmployee(Employee employee, string password, employeeType type)
        {
            try
            {
                db.UpdateEmployee(employee:employee, password: password, type: type.ToString());
            }
            catch (Exception e)
            {
                MessageBox.Show("EmployeeBusinessLogic : updateEmployee ERROR:" + e.Message);
                throw;
            }
        }

        public void addEmplpoyee(Employee employee, string password, string type)
        {
            try
            {
                db.CreateEmployee(employee, password, type);
            }
            catch (Exception e)
            {
                MessageBox.Show("EmployeeBusinessLogic : addEmplpoyee ERROR:" + e.Message);
                throw;
            }
        }

        public void addEmployeeSkill(string employeeID, string skillDescription,employeeSkillCategories category, employeeSkillsTypes type)
        {
            try
            {
                Skill newSkill = new Skill();
                newSkill.ID = ""; // AUTO GENERATRE ID
                newSkill.Description = skillDescription;
                switch (category)
                {
                    case employeeSkillCategories.software:
                        newSkill.Category = "Software";
                        break;
                    case employeeSkillCategories.hardware:
                        newSkill.Category = "Hardware";
                        break;
                    default:
                        break;
                }
                switch (type)
                {
                    case employeeSkillsTypes.installation:
                        newSkill.Type = "Instalation";
                        break;
                    case employeeSkillsTypes.repair:
                        newSkill.Type = "Repair";
                        break;
                    default:
                        break;
                }
                db.CreateSkill(newSkill);
                db.CreateEmployeeSkill(employeeID, newSkill.ID);
            }
            catch (Exception e)
            {
                MessageBox.Show("EmployeeBusinessLogic : addEmployeeSkill ERROR:" + e.Message);
                throw;
            }
        }

        public void updateEmployeeSkill(string skillID, string skillDescription, employeeSkillCategories category, employeeSkillsTypes type) 
        {
            try
            {
                Skill newSkill = new Skill();
                newSkill.ID = skillID;
                newSkill.Description = skillDescription;
                switch (category)
                {
                    case employeeSkillCategories.software:
                        newSkill.Category = "Software";
                        break;
                    case employeeSkillCategories.hardware:
                        newSkill.Category = "Hardware";
                        break;
                    default:
                        break;
                }
                switch (type)
                {
                    case employeeSkillsTypes.installation:
                        newSkill.Type = "Instalation";
                        break;
                    case employeeSkillsTypes.repair:
                        newSkill.Type = "Repair";
                        break;
                    default:
                        break;
                }
                db.UpdateSkill(newSkill);
            }
            catch (Exception e)
            {
                MessageBox.Show("EmployeeBusinessLogic : updateEmployeeSkill ERROR:" + e.Message);
                throw;
            }
        }

        public List<Employee> listEmployeesBySkillCategoryAndType(employeeSkillCategories category, employeeSkillsTypes type)
        {
            try
            {
                string ct = "";
                string tp = "";

                List<Employee> employees = new List<Employee>();
                DataTable employeeData = new DataTable();

                switch (category)
                {
                    case employeeSkillCategories.software:
                        ct = "Software";
                        break;
                    case employeeSkillCategories.hardware:
                        ct = "Hardware";
                        break;
                    default:
                        break;
                }
                switch (type)
                {
                    case employeeSkillsTypes.installation:
                        tp = "Instalation";
                        break;
                    case employeeSkillsTypes.repair:
                        tp = "Repair";
                        break;
                    default:
                        break;
                }

                employeeData = db.ListEmployeesForJob(category: ct, type: tp);

                for (int i = 0; i < employeeData.Rows.Count; i++)
                {
                    employees.Add(new TechnicalStaff(i, employeeData,new Pay("Technician", 600)));
                }

                return employees;
            }
            catch (Exception e)
            {
                MessageBox.Show("EmployeeBusinessLogic : listEmployeesBySkillCategoryAndType ERROR:" + e.Message);
                throw;
            }
        }

        public List<Employee> searchEmployeesByParamater(employeeSearchParamaters employeeSearchParamaters,employeeType employeeType,String query)
        {
            try
            {
                DataTable employeeData = new DataTable();

                switch (employeeSearchParamaters)
                {
                    case employeeSearchParamaters.id:
                        employeeData = db.GetEmployeeByID(id: query);
                        break;
                    case employeeSearchParamaters.email:
                        employeeData = db.GetEmployeeByEmail(email: query);
                        break;
                    case employeeSearchParamaters.phone:
                        employeeData = db.GetEmployeeByContactNumber(number: query);
                        break;
                    default:
                        break;
                }

                if(employeeData != null || employeeData.IsInitialized)
                {
                    for (int i = 0; i < employeeData.Rows.Count; i++)
                    {
                        switch (employeeType)
                        {
                            case employeeType.admin:
                                employees.Add(new Admin(i: i, data: employeeData, pay: new Pay(title: "Admin", 600)));
                                break;
                            case employeeType.callCenter:
                                employees.Add(new CallCenterStaff(i: i, data: employeeData, pay: new Pay(title: "Call Center Staff", 600)));
                                break;
                            case employeeType.technician:
                                employees.Add(new TechnicalStaff(i: i, data: employeeData, pay: new Pay(title: "Technical Staff", 600)));
                                break;
                            default:
                                break;
                        }
                    }
                    return employees;
                }
                return null;
            }
            catch (Exception e)
            {
                MessageBox.Show("EmployeeBusinessLogic : searchEmployeesByParamater ERROR:" + e.Message);
                throw;
            }
        }

        public List<Employee> employeesOnStandBy(employeeType type)
        {
            try
            {
                List<Employee> allEmployees = new List<Employee>();
                List<Employee> employeesOnStandBy = new List<Employee>();
                List<Employee> assignedEmployees = new List<Employee>();
                DataTable jobData = db.ListJobsByStatus("Assigned");
                DataTable employeeData = db.ListEmployees();
                DataTable employeeTypesData = db.ListEmployeesByType();
                for (int i = 0; i < employeeTypesData.Rows.Count; i++)
                {
                    switch (type)
                    {
                        case employeeType.admin:
                            break;
                        case employeeType.callCenter:
                            if(employeeTypesData.Rows[i]["UserType"].ToString() == "CallCentre")
                            {
                                for (int j = 0; j < employeeData.Rows.Count; j++)
                                {
                                    if (employeeTypesData.Rows[i]["AuthenticationID"] == employeeData.Rows[j]["EmpID"])
                                    {
                                        allEmployees.Add(new CallCenterStaff(i: j, data: employeeData, new Pay("Technician", 600)));
                                    }
                                }
                            }
                            break;
                        case employeeType.technician:
                            if (employeeTypesData.Rows[i]["UserType"].ToString() == "Technician")
                            {
                                for (int j = 0; j < employeeData.Rows.Count; j++)
                                {
                                    if (employeeTypesData.Rows[i]["AuthenticationID"] == employeeData.Rows[j]["EmpID"])
                                    {
                                        allEmployees.Add(new TechnicalStaff(i: j, data: employeeData, new Pay("Technician", 600)));
                                    }
                                }
                                
                            }
                            break;
                        default:
                            break;
                    }
                    
                }
                for (int i = 0; i < employeeTypesData.Rows.Count; i++)
                {
                    switch (type)
                    {
                        case employeeType.admin:
                            break;
                        case employeeType.callCenter:
                            if (employeeTypesData.Rows[i]["UserType"].ToString() == "CallCentre")
                            {
                                for (int j = 0; j < employeeData.Rows.Count; j++)
                                {
                                    if(employeeTypesData.Rows[i]["AuthenticationID"] == employeeData.Rows[j]["EmpID"])
                                    {
                                        assignedEmployees.Add(new CallCenterStaff(i: j, data: employeeData, new Pay("Technician", 600)));
                                    }
                                }
                            }
                                break;
                        case employeeType.technician:
                            if (employeeTypesData.Rows[i]["UserType"].ToString() == "Technician")
                            {
                                for (int j = 0; j < employeeData.Rows.Count; j++)
                                {
                                    if (employeeTypesData.Rows[i]["AuthenticationID"] == employeeData.Rows[j]["EmpID"])
                                    {
                                        assignedEmployees.Add(new TechnicalStaff(i: j, data: employeeData, new Pay("Technician", 600)));
                                    }
                                }
                            }
                                break;
                        default:
                            break;
                    }
                }
                employeesOnStandBy = allEmployees.Except(assignedEmployees).ToList();

                return employeesOnStandBy;
            }
            catch (Exception e)
            {
                MessageBox.Show("EmployeeBusinessLogic : employeesOnStandBy ERROR:" + e.Message);
                throw;
            }
        }
    }
}
