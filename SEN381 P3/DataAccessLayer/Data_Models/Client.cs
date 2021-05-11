using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Access_Layer
{
    public abstract class Client : Person
    {
        private string contractID;

        public string ContractID { get => contractID; set => contractID = value; }

        public Client(string id, string firstName, string lastName, string phoneNumber, string address, string email, string contractID) : base(id, firstName, lastName, phoneNumber, address, email) {
            this.contractID = contractID;
        }

        public Client(DataTable data, int i) : base(data,i)
        {
            this.contractID = data.Rows[i]["ContractID"].ToString();
        }
    }
}
