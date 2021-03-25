using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application_Layer
{
    public class Contract
    {
        private string serviceLevel;
        private string skill;

        public string ServiceLevel { get => serviceLevel; set => serviceLevel = value; }
        public string Skill { get => skill; set => skill = value; }

        public Contract(string serviceLevel, string skill)
        {
            this.serviceLevel = serviceLevel;
            this.skill = skill;
        }

        public override string ToString()
        {
            return string.Format("Service Level: {0}\nSkill: {1}", ServiceLevel, Skill);
        }
    }
}
