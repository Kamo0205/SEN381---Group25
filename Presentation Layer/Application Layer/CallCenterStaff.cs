﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application_Layer
{
    public class CallCenterStaff : Employee
    {
        public CallCenterStaff(string firstName, string lastName, string phoneNumber, Pay pay) : base(firstName, lastName, phoneNumber, pay)
        {
            this.Title = "Call Center Staff";
        }
    }
}
