using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Access_Layer
{
    public class Job
    {
        private string id;
        private Employee employee;
        private string clientId;
        private string jobStatus;
        private string description;
        private string type;
        private Pay pay;

        public string Id { get => id; set => id = value; }
        public string Type { get => type; set => type = value; }
        public string Description { get => description; set => description = value; }
        public Employee Employee { get => employee; set => employee = value; }
        public string ClientId { get => clientId; set => clientId = value; }
        public string JobStatus { get => jobStatus; set => jobStatus = value; }
        public Pay Pay { get => pay; set => pay = value; }

        public Job(string id, string clientId, string jobStatus, Pay pay, string description, string type)
        {
            this.clientId = clientId;
            this.type = type;
            this.description = description;
            this.jobStatus = jobStatus;
            this.pay = pay;
            if (id == null)
                this.id = this.GetHashCode().ToString();
            else
                this.id = id;
        }

        private int CharToInt(string word)
        {
            int value = 0;
            foreach (char letter in word)
                value += (int)letter;
            return value;
        } 

        public override int GetHashCode()
        {
            int hash = 1;
            foreach (string word in new string[] { JobStatus, clientId, Employee.Id })
                hash *= CharToInt(word);
            return hash;
        }

        public override bool Equals(object obj)
        {
            return Id.Equals(((Job)obj).Id);
        }
        public override string ToString()
        {
            return string.Format("Employee: {1}\nJob status: {2}",
                Employee.FirstName+" "+Employee.LastName, JobStatus);
        }
    }
}
