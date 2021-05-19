using Business_Logic_Layer;
using Data_Access_Layer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentation_Layer
{
    public partial class AssignJobScreen : Form
    {
        private Job selectedJob;
        private Employee selectedEmployee;
        private JobBusinessLogic jobLogic = new JobBusinessLogic();
        private EmployeeBusinessLogic employeeBusinessLogic = new EmployeeBusinessLogic();

        private employeeSkillsTypes employeeSkills;
        private employeeSkillCategories skillCategories;

        public AssignJobScreen(Job job)
        {
            this.selectedJob = job;
            InitializeComponent();
        }

        private void AssignJobScreen_Load(object sender, EventArgs e)
        {
            switch (selectedJob.JobCategory)
            {
                case "Software":
                    skillCategories = employeeSkillCategories.software;
                    break;
                case "Hardware":
                    skillCategories = employeeSkillCategories.hardware;
                    break;
                default:
                    skillCategories = employeeSkillCategories.software;
                    break;
            }

            switch (selectedJob.JobType)
            {
                case "Installation":
                    employeeSkills = employeeSkillsTypes.installation;
                    break;
                case "Repair":
                    employeeSkills = employeeSkillsTypes.repair;
                    break;
                default:
                    employeeSkills = employeeSkillsTypes.installation;
                    break;
            }

            List<Employee> assignableUsers = employeeBusinessLogic.listEmployeesBySkillCategoryAndType(skillCategories, employeeSkills, true);
            lstTechnicians.DataSource = assignableUsers;
        }

        private void lstTechnicians_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedEmployee = (Employee)lstTechnicians.SelectedItem;

            txtEmployeeName.Text = selectedEmployee.FirstName + " " + selectedEmployee.LastName;
            txtSkill.Text = selectedJob.JobCategory + " : " + selectedJob.JobType;
        }

        private void btnAssignJob_Click(object sender, EventArgs e)
        {
            if(lstTechnicians.SelectedIndex < 0)
            {
                MessageBox.Show("Please select a technician to assign the job to");
            }
            else
            {
                jobLogic.assignJob(selectedJob.Id, selectedEmployee.Id);
                MessageBox.Show(string.Format("Job assigned to {0} {1}", selectedEmployee.FirstName, selectedEmployee.LastName));
                this.Close();
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
