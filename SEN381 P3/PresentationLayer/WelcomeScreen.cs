using Data_Access_Layer;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Presentation_Layer
{
    public partial class FrmWelcomeScreen : Form
    {
        public FrmWelcomeScreen()
        {
            InitializeComponent();
            btnClose.ForeColor = Color.Red;
        }

        private void lblBusinessFunctions_Click(object sender, EventArgs e)
        {
            FrmEditCompanyData buisnessFunctions = new FrmEditCompanyData();
            this.Hide();
            buisnessFunctions.ShowDialog();
            this.Close();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnCallCenter_Click(object sender, EventArgs e)
        {
            //FrmCallCenter callCenter = new FrmCallCenter();
            this.Hide();
            //callCenter.ShowDialog();
            this.Close();
        }

        private void btnServiceDepartment_Click(object sender, EventArgs e)
        {
            Clients_Screen contractScreen = new Clients_Screen();
            this.Hide();
            contractScreen.ShowDialog();
            this.Close();
        }

        private void btnClientSatisfaction_Click(object sender, EventArgs e)
        {
            FrmClientSatisfaction clientSatisfaction = new FrmClientSatisfaction(new Bronze("", "", "", "", "", ""));//TOdo this bad
            this.Hide();
            clientSatisfaction.ShowDialog();
            this.Close();
        }

        private void FrmWelcomeScreen_Load(object sender, EventArgs e)
        {

        }
    }
}
