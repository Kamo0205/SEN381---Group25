using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Data_Access_Layer;
using Business_Logic_Layer;

namespace Presentation_Layer
{
    public partial class JobStatusScreen : Form
    {
        private Contract selectedContract;
        private JobBusinessLogic jobLogic = new JobBusinessLogic();
        private Job selectedJob;
        public JobStatusScreen(Contract contract)
        {
            InitializeComponent();
            this.selectedContract = contract;
        }

        private void JobStatusScreen_Load(object sender, EventArgs e)
        {
            List<Job> jobs = jobLogic.getJobsBySearchParamater(jobSearchParamaters.contractID, this.selectedContract.Id);
            lstJobs.DataSource = jobs;
        }

        private void lstJobs_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedJob = (Job)lstJobs.SelectedItem;
            trvJobStatus.Nodes.Clear();
            if (selectedJob.JobStatus == "Unassigned")
            {
                trvJobStatus.Nodes.Add("Unassigned");
            }else if (selectedJob.JobStatus == "Assigned")
            {
                trvJobStatus.Nodes.Add("Unassigned");
                trvJobStatus.Nodes.Add("Assigned");
            }
            else
            {
                trvJobStatus.Nodes.Add("Unassigned");
                trvJobStatus.Nodes.Add("Assigned");
                trvJobStatus.Nodes.Add("Completed");
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Close();
        }
    }
}
