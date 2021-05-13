using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Access_Layer
{
    public class Admin : Employee
    {
        public Admin(string id,string firstName, string lastName, string phoneNumber,string email,Pay pay, string vatID) : base(id,firstName, lastName, phoneNumber, email,pay, vatID)
        {
            this.Title = "Admin";
        }

        public Admin(int i, DataTable data, Pay pay) : base(i, data, pay)
        {
            this.Title = "Admin";
        }
    }
}
