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
    public partial class FrmCallCenter : Form
    {
        public FrmCallCenter()
        {
            InitializeComponent();
            setContext();
            setData();
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
                switch (details["contract"].ToLower())
                {
                    case "s":
                        dtEndDate.Value = dtStartDate.Value.AddDays(5);
                        break;
                    case "a":
                        dtEndDate.Value = dtStartDate.Value.AddDays(3);
                        break;
                    case "b":
                        dtEndDate.Value = dtStartDate.Value.AddDays(1);
                        break;
                    default:
                        break;
                }
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            FrmWelcomeScreen welcomeScreen = new FrmWelcomeScreen();
            this.Hide();
            welcomeScreen.ShowDialog();
            this.Close();
        }

        private void btnMakeCall_Click(object sender, EventArgs e)
        {
            btnMakeCall.Enabled = false;
            btnPrev.Enabled = false;
            btnNext.Enabled = false;
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
            btnPrev.Enabled = true;
            btnNext.Enabled = true;
            btnLeaveCall.Enabled = false;
            lblCallLoad.Text = "Disconnected";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            setContext();

            txtDetails.Text = string.Empty;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtDetails.Text = string.Empty;
            dtStartDate.Value = DateTime.Now;

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

        private void cmbClientName_SelectedIndexChanged(object sender, EventArgs e)
        {
            //setContext();
            setData();
        }
    }
}
