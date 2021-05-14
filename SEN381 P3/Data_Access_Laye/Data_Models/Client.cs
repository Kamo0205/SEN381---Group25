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
        public Client(string id, string firstName, string lastName, string phoneNumber, string address, string email) : base(id, firstName, lastName, phoneNumber, address, email) {
        }

        public Client(DataTable data, int i) : base(data,i)
        {
        }
    }
}
