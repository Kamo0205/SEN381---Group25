using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Access_Layer
{
    public class Skills
    {
        private string[] availableSkills = new string[] { "Hardware", "Software", "Devices"};
        private string id;
        private string description;
        private string type;

        public string[] AvailableSkills { get => availableSkills; set => availableSkills = value; }

        

        public string ID { get => id; set => id = value; }
        public string Description { get => description; set => description = value; }
        public string Type { get => type; set => type = value; }


        public Skills(string id, string description, string type)
        {
            this.id = id;
            this.description = description;
            this.type = type;
        }
    }
}
