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
    public partial class FrmEditCompanyData : Form
    {
        public FrmEditCompanyData()
        {
            InitializeComponent();
            BindingSource bsCombo = new BindingSource();
            bsCombo.DataSource = new string[] { "Clients", "Employees"};
            cmbChoice.DataSource = bsCombo;
            cmbChoice.SelectedIndex = 0;
            cmbEmployeeClassificaion.Items.Add("Admin");
            cmbEmployeeClassificaion.Items.Add("Call Center");
            cmbEmployeeClassificaion.Items.Add("Technical");
            cmbEmployeeSkill.Items.Add("Admin");
            cmbEmployeeSkill.Items.Add("Call Center");
            cmbEmployeeSkill.Items.Add("Hardware");
            cmbEmployeeSkill.Items.Add("Software");
            cmbEmployeeSkill.Items.Add("Devices");/*
            cmbClientContractType.Items.Add("S");
            cmbClientContractType.Items.Add("A");
            cmbClientContractType.Items.Add("B");*/
            SetContext();
            setData();
        }

        public void setData()
        {
            Dictionary<string, string> details;
            switch (cmbChoice.SelectedIndex)
            {
                case 0:
                    details = new Dictionary<string, string>();
                    if (details.Count > 0)
                    {
                        txtClientId.Text = details["id"];
                        txtClientContractType.Text = details["contract"];
                        switch (details["contract"].ToLower())
                        {
                            case "s":
                                cmbClientContractType.SelectedIndex = 0;
                                break;
                            case "a":
                                cmbClientContractType.SelectedIndex = 1;
                                break;
                            case "b":
                                cmbClientContractType.SelectedIndex = 2;
                                break;
                            default:
                                break;
                        }
                        txtClientFirstName.Text = details["firstName"];
                        txtClientLastName.Text = details["lastName"];
                        txtClientPhoneNumber.Text = details["phoneNumber"];
                        txtClientLocation.Text = details["location"];
                    }
                    break;
                case 1:
                    details = new Dictionary<string, string>();
                    if (details.Count > 0)
                    {
                        txtEmployeeId.Text = details["id"];
                        txtEmployeeSkill.Text = details["skill"];
                        switch (details["skill"].ToLower())
                        {
                            case "admin":
                                cmbEmployeeSkill.SelectedIndex = 0;
                                break;
                            case "call center":
                                cmbEmployeeSkill.SelectedIndex = 1;
                                break;
                            case "hardware":
                                cmbEmployeeSkill.SelectedIndex = 2;
                                break;
                            case "software":
                                cmbEmployeeSkill.SelectedIndex = 3;
                                break;
                            case "devices":
                                cmbEmployeeSkill.SelectedIndex = 4;
                                break;
                            default:
                                break;
                        }
                        txtEmployeeClassificaion.Text = details["classification"];
                        switch (details["classification"].ToLower())
                        {
                            case "admin":
                                cmbEmployeeClassificaion.SelectedIndex = 0;
                                break;
                            case "call center":
                                cmbEmployeeClassificaion.SelectedIndex = 1;
                                break;
                            case "technical":
                                cmbEmployeeClassificaion.SelectedIndex = 2;
                                break;
                            default:
                                break;
                        }
                        txtEmployeeFirstName.Text = details["firstName"];
                        txtEmployeeLastName.Text = details["lastName"];
                        txtEmployeePhoneNumber.Text = details["phoneNumber"];
                    }
                    break;
                default:
                    break;
            }
        }

        public void SetContext()
        {
            BindingSource bsSource;
            switch (cmbChoice.SelectedIndex)
            {
                case 0:
                    bsSource = new BindingSource();
                    bsSource.DataSource = new Dictionary<string, string>();
                    lstData.DataSource = bsSource;
                    pnlClientData.Visible = true;
                    pnlClientData.BringToFront();
                    pnlEmployeeData.Visible = false;
                    break;
                case 1:
                    bsSource = new BindingSource();
                    bsSource.DataSource = new Dictionary<string, string>();
                    lstData.DataSource = bsSource;
                    pnlEmployeeData.Visible = true;
                    pnlEmployeeData.BringToFront();
                    pnlClientData.Visible = false;
                    break;
                default:
                    break;
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            FrmWelcomeScreen home = new FrmWelcomeScreen();
            this.Hide();
            home.ShowDialog();
            this.Close();
        }

        private void cmbChoice_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetContext();
            setData();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            int numberOfItems = lstData.Items.Count;
            if (lstData.SelectedIndex == (numberOfItems - 1))
                lstData.SelectedIndex = 0;
            else
                lstData.SelectedIndex++;
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            int numberOfItems = lstData.Items.Count;
            if (lstData.SelectedIndex == 0)
                lstData.SelectedIndex = (numberOfItems - 1);
            else
                lstData.SelectedIndex--;
        }

        private void lstData_SelectedIndexChanged(object sender, EventArgs e)
        {
            setData();
        }

        private void btnClientClear_Click(object sender, EventArgs e)
        {
            if (chkClientEdit.CheckState == CheckState.Unchecked)
            {
                txtClientId.Text = string.Empty;
                txtClientContractType.Text = string.Empty;
                txtClientFirstName.Text = string.Empty;
                txtClientLastName.Text = string.Empty;
                txtClientPhoneNumber.Text = string.Empty;
                txtClientLocation.Text = string.Empty;
            }
        }

        private void chkEdit_CheckStateChanged(object sender, EventArgs e)
        {
            txtClientId.Enabled = !txtClientId.Enabled;
            txtClientContractType.Enabled = !txtClientContractType.Enabled;
            txtClientFirstName.Enabled = !txtClientFirstName.Enabled;
            txtClientLastName.Enabled = !txtClientLastName.Enabled;
            txtClientPhoneNumber.Enabled = !txtClientPhoneNumber.Enabled;
            txtClientLocation.Enabled = !txtClientLocation.Enabled;
            btnClientAdd.Enabled = !btnClientAdd.Enabled;
            btnClientRemove.Enabled = !btnClientRemove.Enabled;
            btnClientUpdate.Enabled = !btnClientUpdate.Enabled;
            setData();
        }

        private void btnEmployeeClear_Click(object sender, EventArgs e)
        {
            if (chkEmployeeEdit.CheckState == CheckState.Unchecked)
            {
                txtEmployeeId.Text = string.Empty;
                txtEmployeeSkill.Text = string.Empty;
                txtEmployeeClassificaion.Text = string.Empty;
                txtEmployeeFirstName.Text = string.Empty;
                txtEmployeeLastName.Text = string.Empty;
                txtEmployeePhoneNumber.Text = string.Empty;
            }
        }

        private void chkEmployeeEdit_CheckStateChanged(object sender, EventArgs e)
        {
            txtEmployeeId.Enabled = !txtEmployeeId.Enabled;
            txtEmployeeSkill.Enabled = !txtEmployeeSkill.Enabled;
            txtEmployeeClassificaion.Enabled = !txtEmployeeClassificaion.Enabled;
            txtEmployeeFirstName.Enabled = !txtEmployeeFirstName.Enabled;
            txtEmployeeLastName.Enabled = !txtEmployeeLastName.Enabled;
            txtEmployeePhoneNumber.Enabled = !txtEmployeePhoneNumber.Enabled;
            btnEmployeeAdd.Enabled = !btnEmployeeAdd.Enabled;
            btnEmployeeRemove.Enabled = !btnEmployeeRemove.Enabled;
            btnEmployeeUpdate.Enabled = !btnEmployeeUpdate.Enabled;
            setData();
        }

        private void btnEmployeeAdd_Click(object sender, EventArgs e)
        {
            if (chkEmployeeEdit.CheckState == CheckState.Unchecked)
            {
                Dictionary<string, string> newEmployee = new Dictionary<string, string>();
                newEmployee.Add("id", (lstData.Items.Count+1).ToString());
                newEmployee.Add("skill", cmbEmployeeSkill.SelectedItem.ToString());
                newEmployee.Add("classification", cmbEmployeeClassificaion.SelectedItem.ToString());
                newEmployee.Add("firstName", txtEmployeeFirstName.Text);
                newEmployee.Add("lastName", txtEmployeeLastName.Text);
                newEmployee.Add("phoneNumber", txtEmployeePhoneNumber.Text);
                DialogResult dResult = MessageBox.Show(string.Format("Do you wish to add this employee?\nclient: {0}", newEmployee["firstName"] + " " + newEmployee["lastName"]),
                "Conformation", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (dResult == DialogResult.OK)
                SetContext();
            }
        }

        private void btnEmployeeUpdate_Click(object sender, EventArgs e)
        {
            if (chkEmployeeEdit.CheckState == CheckState.Unchecked)
            {

            }
        }

        private void btnEmployeeRemove_Click(object sender, EventArgs e)
        {
            Dictionary<string, string> employee = new Dictionary<string, string>();
            DialogResult dResult = MessageBox.Show(string.Format("Do you wish to remove this employee?\nclient: {0}", employee["firstName"] + " " + employee["lastName"]),
                "Conformation", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
            if (dResult == DialogResult.OK)
            SetContext();
        }

        private void btnClientAdd_Click(object sender, EventArgs e)
        {
            if (chkClientEdit.CheckState == CheckState.Unchecked)
            {
                Dictionary<string, string> newClient = new Dictionary<string, string>();
                newClient.Add("id", txtClientId.Text);
                newClient.Add("contract", cmbClientContractType.SelectedItem.ToString());
                newClient.Add("firstName", txtClientFirstName.Text);
                newClient.Add("lastName", txtClientLastName.Text);
                newClient.Add("location", txtClientLocation.Text);
                newClient.Add("phoneNumber", txtClientPhoneNumber.Text);
                DialogResult dResult = MessageBox.Show(string.Format("Do you wish to add this client?\nclient: {0}", newClient["firstName"] + " " + newClient["lastName"]),
                "Conformation", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (dResult == DialogResult.OK)
                SetContext();
            }
        }

        private void btnClientUpdate_Click(object sender, EventArgs e)
        {
            if (chkClientEdit.CheckState == CheckState.Unchecked)
            {

            }
        }

        private void btnClientRemove_Click(object sender, EventArgs e)
        {
            Dictionary<string, string> client = new Dictionary<string, string>();
            DialogResult dResult = MessageBox.Show(string.Format("Do you wish to remove this client?\nclient: {0}",client["firstName"]+" "+client["lastName"]),
                "Conformation", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
            if (dResult == DialogResult.OK)
            SetContext();
        }
    }
}
