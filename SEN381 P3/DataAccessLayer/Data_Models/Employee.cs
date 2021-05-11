using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Access_Layer
{
    public abstract class Employee : Person
    {
        private Pay pay;
        private string title;
        private string vatID;

        public Pay Pay { get => pay; set => pay = value; }
        public string Title { get => title; set => title = value; }
        public string VatID { get => vatID; set => vatID = value; }

        public Employee(string id,string firstName, string lastName, string phoneNumber,string email ,Pay pay, string vatID) : base(id,firstName, lastName, phoneNumber,email)
        {
            this.pay = pay;
            this.vatID = vatID;
        }

        public Employee(int i, DataTable data, Pay pay) : base(i, data)
        {
            this.vatID = data.Rows[i]["VatIDNumber"].ToString();
            this.pay = pay;
        }
    }
}
