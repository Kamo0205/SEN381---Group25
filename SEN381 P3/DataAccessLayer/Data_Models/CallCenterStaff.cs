using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Access_Layer
{
    public class CallCenterStaff : Employee
    {
        public CallCenterStaff(string firstName, string lastName, string phoneNumber, Pay pay,string vatID) : base(firstName, lastName, phoneNumber, pay, vatID)
        {
            this.Title = "Call Center Staff";
        }
    }
}
