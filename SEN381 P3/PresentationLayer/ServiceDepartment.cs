using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Business_Logic_Layer;
using Data_Access_Layer;
using Presentation_Layer;

namespace Presentation_Layer
{
    public partial class FrmServiceDepartment : Form
    {
        private JobBusinessLogic jobLogic = new JobBusinessLogic();
        private Job selectedJob;
        private Contract selectedContract;
        private Prompt prompt = new Prompt();
        private BindingSource contractBind = new BindingSource();

        private void populateJobCategory()
        {
            cmbJobCategory.Items.Add(new ComboBoxItem(name: "Hardware", id: 0));
            cmbJobCategory.Items.Add(new ComboBoxItem(name: "Software", id: 1));
            cmbJobCategory.DisplayMember = "Name";
            cmbJobCategory.ValueMember = "Id";
        }

        private void populateJobType()
        {
            cmbJobType.Items.Add(new ComboBoxItem(name: "Installation", id: 0));
            cmbJobType.Items.Add(new ComboBoxItem(name: "Repair", id: 1));
            cmbJobType.DisplayMember = "Name";
            cmbJobType.ValueMember = "Id";
        }

        public FrmServiceDepartment(Contract contract)
        {
            InitializeComponent();
            this.selectedContract = contract;
        }

        private void FrmServiceDepartment_Load(object sender, EventArgs e)
        {
            populateJobCategory();
            populateJobType();
            List<Job> jobs = jobLogic.getJobsBySearchParamater(jobSearchParamaters.contractID, this.selectedContract.Id);
            contractBind.DataSource = jobs;
            lstJobs.DataSource = contractBind;
            lblServiceLevel.Text = selectedContract.ServiceLevel;
            lblExperationDate.Text = selectedContract.ExperationDate;
        }

        private void lstJobs_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedJob = (Job)lstJobs.SelectedItem;
            cmbJobCategory.Text = selectedJob.JobCategory;
            cmbJobType.Text = selectedJob.JobType;
            txtDescription.Text = selectedJob.JobDescription;
        }

        private void btnCreateJob_Click(object sender, EventArgs e)
        {
            if (txtDescription.Text == "" || txtDescription.TextLength <= 10)
            {
                MessageBox.Show("Please enter a description for the job");
            }
            else
            {
                jobLogic.createJob(new Job(id: null, contractID: selectedContract.Id, employeeID: "", jobStatus: "Unassigned", jobDescription: txtDescription.Text, clientSatisfaction: 0.ToString(), jobCategory: cmbJobCategory.Name, jobType: cmbJobType.Name, pay: new Pay("", 600)));
                MessageBox.Show("Job added to contract!");
            }
        }

        private void btnUpdateJob_Click(object sender, EventArgs e)
        {
            if (lstJobs.SelectedItems.Count < 0)
            {
                MessageBox.Show("No job is currently selected");
            }
            else
            {
                jobLogic.updateJob(new Job(id: selectedJob.Id, contractID: selectedContract.Id, employeeID: selectedJob.EmployeeID, jobStatus: selectedJob.JobStatus, jobDescription: txtDescription.Text, clientSatisfaction: 0.ToString(), jobCategory: cmbJobCategory.Text, jobType: cmbJobType.Text, pay: new Pay("", 600)));
            }
        }

        private void btnDeleteJob_Click(object sender, EventArgs e)
        {
            if (lstJobs.SelectedItems.Count < 0)
            {
                MessageBox.Show("No job is currently selected");
            }
            else
            {
                prompt.ShowDialog(message: "Are you sure you want to delete this Job?", caption: "Delete Job?", method: () => jobLogic.deleteJob(selectedJob.Id));
            }
        }

        private void btnAssignJob_Click(object sender, EventArgs e)
        {
            if (lstJobs.SelectedItems.Count < 0)
            {
                MessageBox.Show("Please select a job to assign to a technician");
            }
            else
            {
                AssignJobScreen assignJobScreen = new AssignJobScreen(selectedJob);
                this.Hide();
                assignJobScreen.ShowDialog();
                this.Close();
            }
        }
    }
}
