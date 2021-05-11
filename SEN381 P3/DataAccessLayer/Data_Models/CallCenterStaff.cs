using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Access_Layer
{
    public class CallCenterStaff : Employee
    {
        public CallCenterStaff(string id,string firstName, string lastName, string phoneNumber, string email,Pay pay,string vatID) : base(id,firstName, lastName, phoneNumber, email, pay, vatID)
        {
            this.Title = "Call Center Staff";
        }

        public CallCenterStaff(int i, DataTable data, Pay pay) : base(i, data, pay)
        {
            this.Title = "Call Center Staff";
        }
    }
}
