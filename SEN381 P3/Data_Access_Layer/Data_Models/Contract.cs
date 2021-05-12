using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Access_Layer
{
    public class Contract
    {
        private string id;
        private string serviceLevel;
        private string experationDate;
        //private string skill;

        public string ID { get => id; set => id = value; }
        public string ServiceLevel { get => serviceLevel; set => serviceLevel = value; }
        public string ExperationDate { get => experationDate; set => experationDate = value; }
        //public string Skill { get => skill; set => skill = value; }

        public Contract(string serviceLevel, /*string skill,*/ string ID, string experationDate)
        {
            this.ID = ID;
            this.serviceLevel = serviceLevel;
            this.experationDate = experationDate;
            //this.skill = skill;
        }

        public Contract(DataTable data, int i)
        {
            this.ID = data.Rows[i]["ContractID"].ToString();
            this.serviceLevel = data.Rows[i]["ServiceLevel"].ToString();
            this.experationDate = data.Rows[i]["ExperationDate"].ToString();
        }

        public override string ToString()
        {
            return string.Format("Service Level: {0}\nExperation Date: {1}", ServiceLevel, ExperationDate);
        }
    }
}
