using Data_Access_Layer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
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

        public List<Employee> employeesOnStandBy()
        {
            try
            {
                List<Employee> employeesOnStandBy = new List<Employee>();
                List<Employee> assignedEmployees = new List<Employee>();
                DataTable jobData = db.ListJobsByStatus("Assigned");
                DataTable employeeData = db.ListEmployees();
                for (int i = 0; i < employeeData.Rows.Count; i++)
                {
                    for (int j = 0; j < jobData.Rows.Count; j++)
                    {
                        if(employeeData.Rows[i]["EmpID"] == jobData.Rows[j]["EmpID"])
                        {
                            assignedEmployees.Add(new TechnicalStaff(i: i, data: employeeData, new Pay("Technician", 600)));
                        }
                    }
                }
                if(assignedEmployees != null)
                {
                    foreach (Employee employee in assignedEmployees)
                    {
                        for (int i = 0; i < employeeData.Rows.Count; i++)
                        {
                            if (employee.Id != employeeData.Rows[i]["EmpID"].ToString())
                            {
                                employeesOnStandBy.Add(new TechnicalStaff(i: i, data: employeeData, new Pay("Technician", 600)));
                            }
                        }
                    }
                }
                else
                {
                    for (int i = 0; i < employeeData.Rows.Count; i++)
                    {
                        employeesOnStandBy.Add(new TechnicalStaff(i: i, data: employeeData, new Pay("Technician", 600)));
                    }
                }
                return employeesOnStandBy;
            }
            catch (Exception e)
            {
                MessageBox.Show("EmployeeBusinessLogic : searchEmployeesByParamater ERROR:" + e.Message);
                throw;
            }
        }
    }
}
