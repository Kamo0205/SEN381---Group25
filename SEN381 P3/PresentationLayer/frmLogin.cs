using System;
using System.Windows.Forms;
using Business_Logic_Layer;
using System.Collections.Generic;
using Data_Access_Layer;

namespace Presentation_Layer
{
    public partial class frmLogin : Form
    {
        AuthenticationBusinessLogic authenticationLogic = new AuthenticationBusinessLogic();

        public frmLogin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(txt_UserName.Text=="" || txt_Password.Text=="")
            {
                MessageBox.Show("Please provide User Name and Password");
                return;
            }
            try
            {
                AuthenticationBusinessLogic authLogic = new AuthenticationBusinessLogic();
                Dictionary<string, string> userAuthDetails = authLogic.Authenticate(txt_UserName.Text, authenticationLogic.Encipher(txt_Password.Text, 12));

                if(userAuthDetails != null)
                {
                    EmployeeBusinessLogic employeeBusinessLogic = new EmployeeBusinessLogic();

                    switch (userAuthDetails["userType"]) {
                        case "CallCentre":
                            List<Employee> callCentreDetails = employeeBusinessLogic.searchEmployeesByParamater(employeeSearchParamaters.id, employeeType.callCenter, userAuthDetails["id"]);
                            this.Hide();
                            FrmCallCenter frmCallCenter = new FrmCallCenter(callCentreDetails[0]);
                            frmCallCenter.Show();
                            break;
                        case "Technician":
                            List<Employee> technicianDetails = employeeBusinessLogic.searchEmployeesByParamater(employeeSearchParamaters.id, employeeType.technician, userAuthDetails["id"]);

                            List<Employee> stanbyEmployees = employeeBusinessLogic.employeesOnStandBy(employeeType.technician);

                            if (stanbyEmployees.Contains(technicianDetails[0]))
                            {
                                AvailableJobsScreen availableJobsScreen = new AvailableJobsScreen();
                                this.Hide();
                                availableJobsScreen.Show();
                            }
                            else
                            {
                                JobScreen jobScreen = new JobScreen();
                                this.Hide();
                                jobScreen.Show();
                            }
                            break;
                        case "Client":
                            ClientBusinessLogic clientBusinessLogic = new ClientBusinessLogic();
                            List<Client> clientDetails = clientBusinessLogic.searchClientByParameter(clientSearchParameter.id, userAuthDetails["id"]);

                            FrmClientSatisfaction clientSatisfaction = new FrmClientSatisfaction(clientDetails[0]);
                            this.Hide();
                            clientSatisfaction.Show();
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

        private void label3_Click(object sender, EventArgs e)
        {
            RegisterScreen registerScreen = new RegisterScreen();
            this.Hide();
            registerScreen.Show();
        }
    }
}
