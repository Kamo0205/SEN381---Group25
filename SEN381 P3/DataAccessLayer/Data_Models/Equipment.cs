using System;
using System.Collections.Generic;
using System.Text;

namespace Data_Access_Layer.Data_Models
{
    public class Equipment
    {
        private string id;
        private string description;

        public string ID { get => id; set => id = value; }
        public string Description { get => description; set => description = value; }

        public Equipment(string id, string description)
        {
            this.id = id;
            this.description = description;
        }

        public override string ToString()
        {
            return string.Format("Description: {0}", description);
        }
    }
}
