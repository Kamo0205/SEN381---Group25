﻿using System;
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
        private string contractID;
        private string jobStatus;
        private string jobDescription;
        private int clientSatisfaction;
        private string jobCategory;
        private string jobType;
        private Pay pay;

        public string Id { get => id; set => id = value; }
        public string EmployeeID { get => employeeID; set => employeeID = value; }
        public string ContractID { get => contractID; set => contractID = value; }
        public string JobStatus { get => jobStatus; set => jobStatus = value; }
        public string JobDescription { get => jobDescription; set => jobDescription = value; }
        public int ClientSatisfaction { get => clientSatisfaction; set => clientSatisfaction = value; }
        public string JobCategory { get => jobCategory; set => jobCategory = value; }
        public string JobType { get => jobType; set => jobType = value; }
        
        public Pay Pay { get => pay; set => pay = value; }

        public Job(string id, string contractID, string employeeID,string jobStatus, string jobDescription, int clientSatisfaction, string jobCategory, string jobType, Pay pay)
        {
            if (id == null)
                this.id = this.GetHashCode().ToString();
            else
                this.id = id;
            this.contractID = contractID;
            this.employeeID = employeeID;
            this.jobStatus = jobStatus;
            this.jobDescription = jobDescription;
            this.clientSatisfaction = clientSatisfaction;
            this.jobCategory = jobCategory;
            this.jobType = jobType;
            this.pay = pay;
        }

        public Job(DataTable data, int i)
        {
            if (id == null)
                this.id = this.GetHashCode().ToString();
            else
                this.id = data.Rows[i]["JobID"].ToString();
            this.contractID = data.Rows[i]["ContractID"] == null ? null : data.Rows[i]["ContractID"].ToString();
            this.employeeID = data.Rows[i]["EmpID"] == null ? null : data.Rows[i]["EmpID"].ToString();
            this.jobStatus = data.Rows[i]["JobStatus"].ToString();
            this.jobDescription = data.Rows[i]["JobDescription"].ToString();
            this.clientSatisfaction = (int)data.Rows[i]["ClientSatisfaction"];
            this.jobCategory = data.Rows[i]["JobCategory"].ToString();
            this.jobType = data.Rows[i]["JobType"].ToString();
        }

        public Job() { }

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
            foreach (string word in new string[] { jobStatus, contractID, employeeID })
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
