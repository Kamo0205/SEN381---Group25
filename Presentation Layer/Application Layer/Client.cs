using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application_Layer
{
    public abstract class Client : Person
    {
        private string location;
        private Contract contract;

        public string Location { get => location; set => location = value; }
        public Contract Contract { get => contract; set => contract = value; }

        public Client(string firstName, string lastName, string phoneNumber, string location) : base(firstName, lastName, phoneNumber)
        {
            this.location = location;
        }
    }
}
