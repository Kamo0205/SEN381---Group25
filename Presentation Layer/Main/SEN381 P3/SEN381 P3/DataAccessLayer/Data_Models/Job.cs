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
        private Client client;
        private string jobStatus;
        private Pay pay;

        public string Id { get => id; set => id = value; }
        public Employee Employee { get => employee; set => employee = value; }
        public Client Client { get => client; set => client = value; }
        public string JobStatus { get => jobStatus; set => jobStatus = value; }
        public Pay Pay { get => pay; set => pay = value; }

        public Job(string id, Client client, string jobStatus, Pay pay)
        {
            this.client = client;
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
            foreach (string word in new string[] { JobStatus, Client.Id, Employee.Id })
                hash *= CharToInt(word);
            return hash;
        }

        public override bool Equals(object obj)
        {
            return Id.Equals(((Job)obj).Id);
        }
        public override string ToString()
        {
            return string.Format("Client: {0}\nEmployee: {1}\nJob status: {2}",
                Client.FirstName+" "+Client.LastName, Employee.FirstName+" "+Employee.LastName, JobStatus);
        }
    }
}
