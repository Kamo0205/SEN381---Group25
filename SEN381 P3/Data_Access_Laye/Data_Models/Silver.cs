using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Access_Layer
{
    public class Silver : Client
    {
        public Silver(string id,string firstName, string lastName, string phoneNumber, string address,string email ,string contractID) : base(id,firstName, lastName, phoneNumber, address,email,contractID)
        {
        }

        public Silver(DataTable data, int i) : base(data, i)
        {
        }
    }
}
