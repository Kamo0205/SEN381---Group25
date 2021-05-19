using System;
using System.Windows.Forms;
using Business_Logic_Layer;
using System.Collections.Generic;
using Data_Access_Layer;
using System.Linq;

namespace Presentation_Layer
{
    public partial class frmLogin : Form
    {
        private AuthenticationBusinessLogic authenticationLogic = new AuthenticationBusinessLogic();
        private JobBusinessLogic jobLogic = new JobBusinessLogic();

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

                            if (stanbyEmployees.FindIndex(employee => employee.Id == technicianDetails[0].Id) >=0)
                            {
                                AvailableJobsScreen availableJobsScreen = new AvailableJobsScreen(technicianDetails[0]);
                                this.Hide();
                                availableJobsScreen.Show();
                            }
                            else
                            {
                                Job currentJob = jobLogic.getJobsBySearchParamater(jobSearchParamaters.employeeID, technicianDetails[0].Id).Except(jobLogic.getJobsBySearchParamater(jobSearchParamaters.status, "Completed")).ToList()[0];
                                JobScreen jobScreen = new JobScreen(job: currentJob, employee: technicianDetails[0]);
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
