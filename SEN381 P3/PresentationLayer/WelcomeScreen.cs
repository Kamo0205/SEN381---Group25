using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationLayer
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
            FrmCallCenter callCenter = new FrmCallCenter();
            this.Hide();
            callCenter.ShowDialog();
            this.Close();
        }

        private void btnServiceDepartment_Click(object sender, EventArgs e)
        {
            FrmServiceDepartment serviceDepartment = new FrmServiceDepartment();
            this.Hide();
            serviceDepartment.ShowDialog();
            this.Close();
        }

        private void btnClientSatisfaction_Click(object sender, EventArgs e)
        {
            FrmClientSatisfaction clientSatisfaction = new FrmClientSatisfaction();
            this.Hide();
            clientSatisfaction.ShowDialog();
            this.Close();
        }
    }
}
