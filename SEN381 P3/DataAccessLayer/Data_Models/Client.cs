using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Access_Layer
{
    public abstract class Client : Person
    {
        private string location;
        private String contractID;

        public string Location { get => location; set => location = value; }
        public String ContractID { get => contractID; set => contractID = value; }

        public Client(string firstName, string lastName, string phoneNumber, string location) : base(firstName, lastName, phoneNumber) {
            this.location = location;
        }
    }
}
