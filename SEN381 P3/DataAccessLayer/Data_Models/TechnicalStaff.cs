using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Access_Layer
{
    public class TechnicalStaff : Employee
    {
        public TechnicalStaff(string firstName, string lastName, string phoneNumber, Pay pay) : base(firstName, lastName, phoneNumber, pay)
        {
            this.Title = "Technical Staff";
        }
    }
}
