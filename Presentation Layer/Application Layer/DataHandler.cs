using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DatabaseLayer;

namespace Application_Layer
{
    public class DataHandler
    {
        private Client[] clients;
        private Employee[] employees;
        private Job job;
        private DatabaseHandler dh;

        public Client[] Clients { get => clients; set => clients = value; }
        public Employee[] Employees { get => employees; set => employees = value; }
        public Job Job { get => job; set => job = value; }

        public DataHandler()
        {
            this.dh = new DatabaseHandler();
        }

        public void ReadClients()
        {
            this.dh.ReadClients();
        }

        public void AddClient()
        {
            
        }

        public void UpdateClient()
        {

        }

        public void RemoveClient()
        {

        }

        public void ReadEmployees()
        {
            this.dh.ReadEmployees();
        }

        public void AddEmployee()
        {
            List<Employee> tmpEmployees = Employees.ToList();
        }

        public void UpdateEmployee()
        {

        }

        public void RemoveEmployee()
        {

        }

        public void ReadJobs()
        {
            this.dh.ReadJobs();
        }

        public void AddTicket()
        {

        }

        public void UpdateTicket()
        {

        }
    }
}
