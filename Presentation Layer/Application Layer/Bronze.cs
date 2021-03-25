using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application_Layer
{
    public class Bronze : Client
    {
        public Bronze(string firstName, string lastName, string phoneNumber, string location) : base(firstName, lastName, phoneNumber, location)
        {
            this.Contract.ServiceLevel = "Bronze";
        }
    }
}
