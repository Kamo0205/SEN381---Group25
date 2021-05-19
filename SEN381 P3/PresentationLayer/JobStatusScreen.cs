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


            rdOneStar.Checked = false;
            rdTwoStar.Checked = false;
            rdThreeStar.Checked = false;
            rdFourStar.Checked = false;
            rdFiveStar.Checked = false;
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

            switch (selectedJob.ClientSatisfaction != null ? selectedJob.ClientSatisfaction : "")
            {
                case "1":
                    rdOneStar.Checked = true;
                    break;
                case "2":
                    rdTwoStar.Checked = true;
                    break;
                case "3":
                    rdThreeStar.Checked = true;
                    break;
                case "4":
                    rdFourStar.Checked = true;
                    break;
                case "5":
                    rdFiveStar.Checked = true;
                    break;
                default:
                    rdOneStar.Checked = true;
                    break;
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Close();
        }

        private void rdOneStar_CheckedChanged(object sender, EventArgs e)
        {
            if (rdOneStar.Checked) {
                JobBusinessLogic jobBusiness = new JobBusinessLogic();

                selectedJob.ClientSatisfaction = "1";

                jobBusiness.updateJob(selectedJob);
            }
        }

        private void rdTwoStar_CheckedChanged(object sender, EventArgs e)
        {
            if (rdTwoStar.Checked)
            {
                JobBusinessLogic jobBusiness = new JobBusinessLogic();

                selectedJob.ClientSatisfaction = "2";

                jobBusiness.updateJob(selectedJob);
            }
        }

        private void rdThreeStar_CheckedChanged(object sender, EventArgs e)
        {
            if (rdThreeStar.Checked){
                JobBusinessLogic jobBusiness = new JobBusinessLogic();

                selectedJob.ClientSatisfaction = "3";

                jobBusiness.updateJob(selectedJob);
        }
        }

        private void rdFourStar_CheckedChanged(object sender, EventArgs e)
        {
            if (rdFourStar.Checked)
            {

                JobBusinessLogic jobBusiness = new JobBusinessLogic();

                selectedJob.ClientSatisfaction = "4";

                jobBusiness.updateJob(selectedJob);
            }
        }

        private void rdFiveStar_CheckedChanged(object sender, EventArgs e)
        {
            if (rdFiveStar.Checked)
            {
                JobBusinessLogic jobBusiness = new JobBusinessLogic();

                selectedJob.ClientSatisfaction = "5";

                jobBusiness.updateJob(selectedJob);
            }
        }
    }
}
