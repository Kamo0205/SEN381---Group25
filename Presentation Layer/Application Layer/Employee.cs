using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application_Layer
{
    public abstract class Employee : Person
    {
        private Pay pay;
        private string title;

        public Pay Pay { get => pay; set => pay = value; }
        public string Title { get => title; set => title = value; }

        public Employee(string firstName, string lastName, string phoneNumber, Pay pay) : base(firstName, lastName, phoneNumber)
        {
            this.pay = pay;
        }
    }
}
