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
    public partial class FrmClientSatisfaction : Form
    {
        public FrmClientSatisfaction()
        {
            InitializeComponent();
            setContext();
        }

        public void setContext()
        {
            BindingSource bsSource = new BindingSource();
            cmbClientName.DataSource = bsSource;
            cmbClientName.DisplayMember = "Id";
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

        private void btnPrev_Click(object sender, EventArgs e)
        {
            int numberOfItems = cmbClientName.Items.Count;
            if (cmbClientName.SelectedIndex == 0)
                cmbClientName.SelectedIndex = (numberOfItems - 1);
            else
                cmbClientName.SelectedIndex--;
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            int numberOfItems = cmbClientName.Items.Count;
            if (cmbClientName.SelectedIndex == (numberOfItems - 1))
                cmbClientName.SelectedIndex = 0;
            else
                cmbClientName.SelectedIndex++;
        }

        private void rdTwoStar_CheckedChanged(object sender, EventArgs e)
        {
            if (rdTwoStar.Checked == true)
                rdOneStar.Checked = true;
        }

        private void rdThreeStar_CheckedChanged(object sender, EventArgs e)
        {
            if (rdThreeStar.Checked == true)
            {
                rdOneStar.Checked = true;
                rdTwoStar.Checked = true;
            }
        }

        private void rdFourStar_CheckedChanged(object sender, EventArgs e)
        {
            if (rdFourStar.Checked == true)
            {
                rdOneStar.Checked = true;
                rdTwoStar.Checked = true;
                rdThreeStar.Checked = true;
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
            }
        }

        private void btnMakeCall_Click(object sender, EventArgs e)
        {
            btnMakeCall.Enabled = false;
            btnLeaveCall.Enabled = true;
            lblCallLoad.ForeColor = Color.Gold;
            lblCallLoad.Text = "Connecting";
            t1.Interval = 500;
            t1.Start();
            lblCallLoad.Text = "Connecting.";
            t1.Start();
            lblCallLoad.Text = "Connecting..";
            t1.Start();
            lblCallLoad.Text = "Connecting...";
            t1.Start();
            lblCallLoad.Text = "Connecting";
            t1.Start();
            lblCallLoad.Text = "Connecting.";
            t1.Start();
            lblCallLoad.Text = "Connecting..";
            t1.Start();
            lblCallLoad.Text = "Connecting...";
            t1.Start();
            lblCallLoad.Text = "Connecting";
            t1.Start();
            lblCallLoad.Text = "Connecting.";
            t1.Start();
            lblCallLoad.Text = "Connected";
            t1.Stop();
            lblCallLoad.ForeColor = Color.GreenYellow;
        }

        private void btnLeaveCall_Click(object sender, EventArgs e)
        {
            btnMakeCall.Enabled = true;
            btnLeaveCall.Enabled = false;
            lblCallLoad.Text = "Disconnected";
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtDetails.Text = string.Empty;
            rdOneStar.Checked = false;
            rdTwoStar.Checked = false;
            rdThreeStar.Checked = false;
            rdFourStar.Checked = false;
            rdFiveStar.Checked = false;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //Save rating
            txtDetails.Text = string.Empty;
            rdOneStar.Checked = false;
            rdTwoStar.Checked = false;
            rdThreeStar.Checked = false;
            rdFourStar.Checked = false;
            rdFiveStar.Checked = false;
        }
    }
}
