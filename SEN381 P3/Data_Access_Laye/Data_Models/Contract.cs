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
        private string clientID;
        private string serviceLevel;
        private string experationDate;

        public string Id { get => id; set => id = value; }
        public string ClientID { get => clientID; set => clientID = value; }
        public string ServiceLevel { get => serviceLevel; set => serviceLevel = value; }
        public string ExperationDate { get => experationDate; set => experationDate = value; }

        public Contract(string id, string clientID,string serviceLevel, string experationDate)
        {
            this.id = id;
            this.clientID = clientID;
            this.serviceLevel = serviceLevel;
            this.experationDate = experationDate;
        }

        public Contract(DataTable data, int i)
        {
            this.id = data.Rows[i]["ContractID"].ToString();
            this.clientID = data.Rows[i]["ClientID"].ToString();
            this.serviceLevel = data.Rows[i]["ServiceLevel"].ToString();
            this.experationDate = data.Rows[i]["ExperationDate"].ToString();
        }

        public override string ToString()
        {
            return string.Format("Service Level: {0}\n Experation Date: {1}", ServiceLevel, ExperationDate);
        }
    }
}
