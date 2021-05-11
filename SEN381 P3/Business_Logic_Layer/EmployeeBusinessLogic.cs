using Data_Access_Layer;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business_Logic_Layer
{
    class EmployeeBusinessLogic
    {
        DBAccess db = new DBAccess();

        List<Employee> employees = new List<Employee>();

        void deleteEmployee()
        {

        }

        void updateEmployee()
        {

        }

        List<Employee> getEmployees(String contactNumber)
        {
            for (int i = 0; i < db.GetEmployeeByContactNumber(contactNumber).Rows.Count; i++)
            {
                employees.Add(new TechnicalStaff(firstName: db.GetEmployeeByContactNumber(contactNumber).Rows[i]["EmpName"].ToString(), lastName: db.GetEmployeeByContactNumber(contactNumber).Rows[i]["EmpSurname"].ToString(), db.GetEmployeeByContactNumber(contactNumber).Rows[i]["ContactNumber"].ToString(), new Pay("Title", 600), db.GetEmployeeByContactNumber(contactNumber).Rows[i]["VatIDNumber"].ToString()));
            }

            return employees;
        }

        void getEmployeesForJob()
        {

        }
    }
}
