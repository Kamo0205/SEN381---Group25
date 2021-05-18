using System;
using System.Windows.Forms;
using Business_Logic_Layer;
using System.Collections.Generic;
using Data_Access_Layer;

namespace LoginApplication
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(txt_UserName.Text=="" || txt_Password.Text=="")
            {
                MessageBox.Show("Please provide UserName and Password");
                return;
            }
            try
            {
                AuthenticationBusinessLogic authLogic = new AuthenticationBusinessLogic();
                Dictionary<string, string> userAuthDetails = authLogic.Authenticate(txt_UserName.Text, txt_Password.Text);

                if(userAuthDetails != null)
                {
                    EmployeeBusinessLogic employeeBusinessLogic = new EmployeeBusinessLogic();

                    switch (userAuthDetails["userType"]) {
                        case "CallCentre":
                            List<Employee> callCentreDetails = employeeBusinessLogic.searchEmployeesByParamater(employeeSearchParamaters.id, employeeType.callCenter, userAuthDetails["id"]);
                            break;
                        case "Technician":
                            List<Employee> technicianDetails = employeeBusinessLogic.searchEmployeesByParamater(employeeSearchParamaters.id, employeeType.technician, userAuthDetails["id"]);
                            break;
                        case "Client":
                            ClientBusinessLogic clientBusinessLogic = new ClientBusinessLogic();
                            clientBusinessLogic.searchClientByParameter(clientSearchParameter.id, userAuthDetails["id"], serviceLevel.bronze);//TODO this should change
                            break;
                        default:
                            break;
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
