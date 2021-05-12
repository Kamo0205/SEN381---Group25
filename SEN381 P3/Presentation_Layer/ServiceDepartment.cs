using System;
using System.Windows.Forms;

namespace PresentationLayer
{
    public partial class FrmServiceDepartment : Form
    {
        BindingSource jobBind = new BindingSource();
        BindingSource employeeBind = new BindingSource();

        public FrmServiceDepartment()
        {
            InitializeComponent();
            setContext();
        }

        public void setContext()
        {
            BindingSource bsSource = new BindingSource();
            lstTechnicians.DataSource = bsSource;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            FrmWelcomeScreen welcomeScreen = new FrmWelcomeScreen();
            this.Hide();
            welcomeScreen.ShowDialog();
            this.Close();
        }

        private void lstTechnicians_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void btnLockInTechnicians_Click(object sender, EventArgs e)
        {
            lstTechnicians.Enabled = !lstTechnicians.Enabled;
            txtEmployeeName.Enabled = !txtEmployeeName.Enabled;
            txtSkill.Enabled = !txtSkill.Enabled;
            txtClassfication.Enabled = !txtClassfication.Enabled;
        }

        private void btnLockInEquipment_Click(object sender, EventArgs e)
        {
            txtEquipment.Enabled = !txtEquipment.Enabled;
        }
    }
}
