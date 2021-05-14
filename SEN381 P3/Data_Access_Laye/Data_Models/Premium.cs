﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Access_Layer
{
    public class Premium : Client
    {
        public Premium(string id, string firstName, string lastName, string phoneNumber, string address, string email) : base(id, firstName, lastName, phoneNumber, address, email)
        {
        }

        public Premium(DataTable data, int i) : base(data, i)
        {
        }
    }
}
