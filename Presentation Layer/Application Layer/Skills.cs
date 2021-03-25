using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application_Layer
{
    class Skills
    {
        private string[] availableSkills = new string[] { "Hardware", "Software", "Devices"};

        public string[] AvailableSkills { get => availableSkills; set => availableSkills = value; }

        public Skills()
        {
        }
    }
}
