using System;
using System.Collections.Generic;
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

        public Employee(string firstName, string lastName, string phoneNumber, Pay pay, string vatID) : base(firstName, lastName, phoneNumber)
        {
            this.pay = pay;
            this.vatID = vatID;
        }
    }
}
