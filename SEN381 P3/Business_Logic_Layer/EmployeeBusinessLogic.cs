using Data_Access_Layer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace Business_Logic_Layer
{
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

        void updateEmployee()
        {

        }

        List<Employee> searchEmployeesByContactNumber(String contactNumber)
        {
            try
            {
                DataTable employeeData = db.GetEmployeeByContactNumber(contactNumber);
                if(employeeData != null || employeeData!.IsInitialized)
                {
                    for (int i = 0; i < employeeData.Rows.Count; i++)
                    {
                        employees.Add(new TechnicalStaff(i: i, data: employeeData, pay: new Pay(title: "Title", 600)));
                    }
                    return employees;
                }
                return null;
            }
            catch (Exception e)
            {
                MessageBox.Show("EmployeeBusinessLogic : searchEmployeesByContactNumber ERROR:" + e.Message);
                throw;
            }
        }

        void getEmployeesForJob()
        {

        }
    }
}
