using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Access_Layer
{
    public class Job
    {
        private string id;
        private string employeeID;
        private string clientID;
        private string jobStatus;
        private string jobDescription;
        private string jobType;
        private Pay pay;

        public string Id { get => id; set => id = value; }
        public string JobType { get => jobType; set => jobType = value; }
        public string JobDescription { get => jobDescription; set => jobDescription = value; }
        public string EmployeeID { get => employeeID; set => employeeID = value; }
        public string ClientID { get => clientID; set => clientID = value; }
        public string JobStatus { get => jobStatus; set => jobStatus = value; }
        public Pay Pay { get => pay; set => pay = value; }

        public Job(string id, string clientID, string employeeID,string jobStatus, Pay pay, string jobDescription, string jobType)
        {
            this.clientID = clientID;
            this.employeeID = employeeID;
            this.jobType = jobType;
            this.jobDescription = jobDescription;
            this.jobStatus = jobStatus;
            this.pay = pay;
            if (id == null)
                this.id = this.GetHashCode().ToString();
            else
                this.id = id;
        }

        public Job(DataTable data, int i)
        {
            if (id == null)
                this.id = this.GetHashCode().ToString();
            else
                this.id = data.Rows[i]["JobID"].ToString();
            this.clientID = data.Rows[i]["ClientID"].ToString();
            this.employeeID = data.Rows[i]["EmpID"].ToString();
            this.jobDescription = data.Rows[i]["JobDescription"].ToString();
            this.jobType = data.Rows[i]["JobType"].ToString();
            this.jobStatus = data.Rows[i]["JobStatus"].ToString();
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
            foreach (string word in new string[] { jobStatus, clientID, employeeID })
                hash *= CharToInt(word);
            return hash;
        }

        public override bool Equals(object obj)
        {
            return Id.Equals(((Job)obj).Id);
        }
        public override string ToString()
        {
            return string.Format("EmployeeID: {1}\nJob status: {2}",
                employeeID, jobStatus);
        }
    }
}
