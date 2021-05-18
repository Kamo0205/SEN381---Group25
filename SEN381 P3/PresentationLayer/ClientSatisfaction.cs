using Business_Logic_Layer;
using Data_Access_Layer;
using Presentation_Layer;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace PresentationLayer
{
    public partial class FrmClientSatisfaction : Form
    {
        private JobBusinessLogic jobInformation = new JobBusinessLogic();
        private Client loggedInClient;
        private int satisfaction;

        public FrmClientSatisfaction(Client client)
        {
            InitializeComponent();
            this.loggedInClient = client;
        }

        private void FrmClientSatisfaction_Load(object sender, EventArgs e)
        {
            lblCallerName.Text = loggedInClient.FirstName + " " + loggedInClient.LastName;
        }

        public void setData()
        {
            Dictionary<string, string> details = new Dictionary<string, string>();
            if (details.Count > 0)
            {
                lblCallerName.Text = details["firstName"] + " " + details["lastName"];
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            FrmWelcomeScreen welcomeScreen = new FrmWelcomeScreen();
            this.Hide();
            welcomeScreen.ShowDialog();
            this.Close();
        }

        private void rdTwoStar_CheckedChanged(object sender, EventArgs e)
        {
            if (rdTwoStar.Checked == true)
            {
                rdOneStar.Checked = true;
                satisfaction = 2;
            }
                
        }

        private void rdThreeStar_CheckedChanged(object sender, EventArgs e)
        {
            if (rdThreeStar.Checked == true)
            {
                rdOneStar.Checked = true;
                rdTwoStar.Checked = true;
                satisfaction = 3;
            }
        }

        private void rdFourStar_CheckedChanged(object sender, EventArgs e)
        {
            if (rdFourStar.Checked == true)
            {
                rdOneStar.Checked = true;
                rdTwoStar.Checked = true;
                rdThreeStar.Checked = true;
                satisfaction = 4;
            }
        }

        private void rdFiveStar_CheckedChanged(object sender, EventArgs e)
        {
            if (rdFiveStar.Checked == true)
            {
                rdOneStar.Checked = true;
                rdTwoStar.Checked = true;
                rdThreeStar.Checked = true;
                rdFourStar.Checked = true;
                satisfaction = 5;
            }
        }

        private void btnMakeCall_Click(object sender, EventArgs e)
        {
            jobInformation.createJob(new Job(id: null,contractID: null, employeeID: null,jobStatus: "Unassigned", jobDescription: "CallCentre", clientSatisfaction:0, jobCategory:"CallCentre", jobType:"CallCentre",new Pay("",600)));
        }

        private void btnLeaveCall_Click(object sender, EventArgs e)
        {
            List<Job> callJobs = jobInformation.listJobsByCategoryAndType(jobCategory.callCentre, jobType.callCentre);
            foreach (Job job in callJobs)
            {
                if(job.JobStatus == "Unassigned")
                {
                    jobInformation.deleteJob(job.Id);
                }else if (job.JobStatus == "Assigned")
                {
                    jobInformation.updateJob(new Job(id: job.Id, contractID:job.ContractID,employeeID:job.EmployeeID,jobStatus:job.JobStatus, jobDescription: job.JobDescription,clientSatisfaction: this.satisfaction, jobCategory:job.JobCategory, jobType: job.JobType, new Pay("", 600)));
                }
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            rdOneStar.Checked = false;
            rdTwoStar.Checked = false;
            rdThreeStar.Checked = false;
            rdFourStar.Checked = false;
            rdFiveStar.Checked = false;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            rdOneStar.Checked = false;
            rdTwoStar.Checked = false;
            rdThreeStar.Checked = false;
            rdFourStar.Checked = false;
            rdFiveStar.Checked = false;
        }

        private void btnPersonalDetails_Click(object sender, EventArgs e)
        {
            ClientPage clientPage = new ClientPage();
            this.Hide();
            clientPage.ShowDialog();
            this.Close();
        }

        private void btnContractScreen_Click(object sender, EventArgs e)
        {
            Clients_Screen clientsScreen = new Clients_Screen();
        }
    }
}
