using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Business_Logic_Layer;
using Data_Access_Layer;

namespace Presentation_Layer
{
    public partial class JobScreen : Form
    {
        private Job assignedJob;
        private Employee loggedEmployee;
        private JobBusinessLogic jobLogic = new JobBusinessLogic();
        private Prompt prompt = new Prompt();
        public JobScreen(Job job, Employee employee)
        {
            InitializeComponent();
            this.assignedJob = job;
            this.loggedEmployee = employee;
        }

        private void JobScreen_Load(object sender, EventArgs e)
        {
            lblDescription.Text = assignedJob.JobDescription;
            lblJobCategory.Text = assignedJob.JobCategory;
            lblJobType.Text = assignedJob.JobType;
            lblStatus.Text = assignedJob.JobStatus;
        }

        private void btnSignOut_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmLogin frmLogin = new frmLogin();
            frmLogin.Show();
            this.Close();
        }

        private void btnAbandonJob_Click(object sender, EventArgs e)
        {
            prompt.ShowDialog(message: "Are you sure you want to abandon this job?",caption: "Abondon Job?" ,method: () => jobLogic.updateJob(new Job(id:assignedJob.Id, contractID: assignedJob.ContractID,employeeID: assignedJob.EmployeeID ,jobStatus: "Unassigned", jobDescription: assignedJob.JobDescription, clientSatisfaction: assignedJob.ClientSatisfaction, jobCategory: assignedJob.JobCategory, jobType: assignedJob.JobType, pay: assignedJob.Pay)));
            AvailableJobsScreen availableJobsScreen = new AvailableJobsScreen(loggedEmployee);
            this.Hide();
            availableJobsScreen.Show();
            this.Close();
        }

        private void btnFinishJob_Click(object sender, EventArgs e)
        {
            jobLogic.updateJob(new Job(id: assignedJob.Id, contractID: assignedJob.ContractID, employeeID: assignedJob.EmployeeID, jobStatus: "Completed", jobDescription: assignedJob.JobDescription, clientSatisfaction: assignedJob.ClientSatisfaction, jobCategory: assignedJob.JobCategory, jobType: assignedJob.JobType, pay: assignedJob.Pay));
            AvailableJobsScreen availableJobsScreen = new AvailableJobsScreen(loggedEmployee);
            this.Hide();
            availableJobsScreen.Show();
            this.Close();
        }
    }
}
