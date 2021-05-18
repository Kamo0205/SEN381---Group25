using System;
using System.Windows.Forms;
using Data_Access_Layer;
using Business_Logic_Layer;
using Presentation_Layer;

namespace Presentation_Layer
{
    public partial class FrmCallCenter : Form
    {
        private Employee loggedEmployee;
        public FrmCallCenter(Employee employee)
        {
            InitializeComponent();
            this.loggedEmployee = employee;
        }

        private void btnMakeCall_Click(object sender, EventArgs e)
        {
            
        }

        private void btnLeaveCall_Click(object sender, EventArgs e)
        {

        }

        private void btnClientScreen_Click(object sender, EventArgs e)
        {
            Clients_Screen clientsScreen = new Clients_Screen();
            clientsScreen.Show();
        }

        private void FrmCallCenter_Load(object sender, EventArgs e)
        {
            lblEmployeeName.Text = loggedEmployee.FirstName + " " + loggedEmployee.LastName;
        }

        private void btnSignOut_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmLogin login = new frmLogin();
            login.Show();
            this.Close();
        }

        private void btnAddEmployee_Click(object sender, EventArgs e)
        {
            AddEmployeeScreen employeeScreen = new AddEmployeeScreen();
            employeeScreen.Show();
        }

        private void btnEditDetails_Click(object sender, EventArgs e)
        {
            EmployeePage employeePage = new EmployeePage();
            employeePage.Show();
        }
    }
}
