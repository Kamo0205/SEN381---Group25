using Data_Access_Layer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace Business_Logic_Layer
{
    enum employeeType
    {
        admin,
        callCenter,
        technician
    }

    enum employeeSearchParamaters{
        id,
        email,
        phone
    }

    class EmployeeBusinessLogic
    {
        DBAccess db = new DBAccess();

        List<Employee> employees = new List<Employee>();

        void deleteEmployee(string id)
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

        void updateEmployee(Employee employee)
        {
            try
            {
                db.UpdateEmployee(employee:employee);
            }
            catch (Exception e)
            {
                MessageBox.Show("EmployeeBusinessLogic : updateEmployee ERROR:" + e.Message);
                throw;
            }
        }

        List<Employee> searchEmployeesByParamater(employeeSearchParamaters employeeSearchParamaters,employeeType employeeType,String query)
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

                if(employeeData != null || employeeData!.IsInitialized)
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

        
    }
}
