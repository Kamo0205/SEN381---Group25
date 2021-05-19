using System;
using System.Windows.Forms;
using Business_Logic_Layer;
using Data_Access_Layer;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentation_Layer
{
    public partial class AvailableJobsScreen : Form
    {
        private Employee loggedEmployee;
        private JobBusinessLogic jobLogic = new JobBusinessLogic();
        private EmployeeBusinessLogic employeeLogic = new EmployeeBusinessLogic();
        private ContractBusinessLogic contractLogic = new ContractBusinessLogic();
        private ClientBusinessLogic clientLogic = new ClientBusinessLogic();

        private Job selectedJob;
        private Contract jobContract;
        private Client jobClient;

        public AvailableJobsScreen(Employee employee)
        {
            InitializeComponent();
            this.loggedEmployee = employee;
        }

        private void AvailableJobsScreen_Load(object sender, EventArgs e)
        {
            jobCategory jobCategory;
            jobType jobType;

            switch (employeeLogic.getEmployeeSkills(loggedEmployee)[0].Category)
            {
                case "Software":
                    jobCategory = jobCategory.software;
                    break;
                case "Hardware":
                    jobCategory = jobCategory.hardware;
                    break;
                default:
                    jobCategory = jobCategory.hardware;
                    break;
            }

            switch (employeeLogic.getEmployeeSkills(loggedEmployee)[0].Type)
            {
                case "Installation":
                    jobType = jobType.installation;
                    break;
                case "Repair":
                    jobType = jobType.repair;
                    break;
                default:
                    jobType = jobType.installation;
                    break;
            }

            lstJobs.DataSource = jobLogic.listUnassignedJobByCategoryAndType(jobCategory,jobType);
        }

        private void lstJobs_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedJob = (Job)lstJobs.SelectedItem;
            jobContract = contractLogic.listContractsBySearchParamater(contractSearchParamaters.id, query: selectedJob.ContractID)[0];
            jobClient = clientLogic.searchClientByParameter(clientSearchParameter.id, query: jobContract.ClientID)[0];

            txtClientName.Text = jobClient.FirstName + " " + jobClient.LastName;
            txtClientAddress.Text = jobClient.Address;
            txtServiceLevel.Text = jobContract.ServiceLevel;
        }

        private void btnSignOut_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmLogin frmLogin = new frmLogin();
            frmLogin.Show();
            this.Close();
        }

        private void btnTakeJob_Click(object sender, EventArgs e)
        {
            if (lstJobs.SelectedIndex < 0)
            {
                MessageBox.Show("No job is currently selected");
            }
            else
            {
                jobLogic.assignJob(selectedJob.Id, loggedEmployee.Id);
                this.Hide();
                JobScreen jobScreen = new JobScreen(new Job(id:selectedJob.Id,contractID:jobContract.Id,employeeID:loggedEmployee.Id,jobStatus:"Assigned",jobDescription:selectedJob.JobDescription,clientSatisfaction:selectedJob.ClientSatisfaction,jobCategory:selectedJob.JobCategory,jobType:selectedJob.JobType,new Pay("",600)), loggedEmployee);
                jobScreen.Show();
                this.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            EmployeePage employeePage = new EmployeePage(loggedEmployee);
            employeePage.Show();
        }
    }
}
