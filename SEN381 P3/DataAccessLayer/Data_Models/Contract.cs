﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Access_Layer
{
    public class Contract
    {
        private string id;
        private string serviceLevel;
        private string skill;

        public string ID { get => id; set => id = value; }
        public string ServiceLevel { get => serviceLevel; set => serviceLevel = value; }
        public string Skill { get => skill; set => skill = value; }

        public Contract(string serviceLevel, string skill, string ID)
        {
            this.ID = ID;
            this.serviceLevel = serviceLevel;
            this.skill = skill;
        }

        public override string ToString()
        {
            return string.Format("Service Level: {0}\nSkill: {1}", ServiceLevel, Skill);
        }
    }
}
