using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
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
        private static readonly RNGCryptoServiceProvider random = new RNGCryptoServiceProvider();

        public string Id { get => id; set => id = value; }
        public string ClientID { get => clientID; set => clientID = value; }
        public string ServiceLevel { get => serviceLevel; set => serviceLevel = value; }
        public string ExperationDate { get => experationDate; set => experationDate = value; }

        public Contract(string id, string clientID,string serviceLevel, string experationDate)
        {
            this.id = id == null ? GenerateUniqueID() : id;
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

        private string GenerateUniqueID()
        {
            var buffer = new byte[8];
            random.GetBytes(buffer);
            return Convert.ToBase64String(buffer).Substring(0, 8);
        }
    }
}
