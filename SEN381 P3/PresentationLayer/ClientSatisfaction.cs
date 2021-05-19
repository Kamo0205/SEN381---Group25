using Business_Logic_Layer;
using Data_Access_Layer;
using Presentation_Layer;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Presentation_Layer
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
            frmLogin welcomeScreen = new frmLogin();
            this.Hide();
            welcomeScreen.Show();
        }

        private void btnMakeCall_Click(object sender, EventArgs e)
        {
        }

        private void btnLeaveCall_Click(object sender, EventArgs e)
        {
        }

        private void btnPersonalDetails_Click(object sender, EventArgs e)
        {
            ClientPage clientPage = new ClientPage(loggedInClient);
            clientPage.Show();
        }

        private void btnContractScreen_Click(object sender, EventArgs e)
        {
            Clients_Screen clientsScreen = new Clients_Screen(loggedInClient);
            clientsScreen.Show();
        }
    }
}
