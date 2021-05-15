using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Access_Layer
{
    public class Skill
    {
        private string[] availableSkills = new string[] { "Hardware", "Software", "Devices"};
        private string id;
        private string description;
        private string category;
        private string type;

        public string[] AvailableSkills { get => availableSkills; set => availableSkills = value; }

        

        public string ID { get => id; set => id = value; }
        public string Description { get => description; set => description = value; }
        public string Category { get => category; set => category = value; }
        public string Type { get => type; set => type = value; }
        


        public Skill(string id, string description, string category,string type)
        {
            this.id = id;
            this.description = description;
            this.category = category;
            this.type = type;
        }

        public Skill(DataTable data, int i)
        {
            this.id = data.Rows[i]["SkillID"].ToString();
            this.description = data.Rows[i]["SkillDescription"].ToString();
            this.category = data.Rows[i]["SkillCategory"].ToString();
            this.type = data.Rows[i]["SkillType"].ToString();
        }

        public Skill()
        {

        }
    }
}
