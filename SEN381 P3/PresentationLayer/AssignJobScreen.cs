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

        public AssignJobScreen(Job job)
        {
            this.selectedJob = job;
            InitializeComponent();
        }

        private void AssignJobScreen_Load(object sender, EventArgs e)
        {
            EmployeeBusinessLogic employeeBusinessLogic = new EmployeeBusinessLogic();

            employeeSkillsTypes employeeSkills;
            employeeSkillCategories skillCategories;

            switch (selectedJob.JobCategory)
            {
                case "software":
                    skillCategories = employeeSkillCategories.software;
                    break;
                case "hardware":
                    skillCategories = employeeSkillCategories.hardware;
                    break;
                default:
                    skillCategories = employeeSkillCategories.software;
                    break;
            }

            switch (selectedJob.JobType)
            {
                case "installation":
                    employeeSkills = employeeSkillsTypes.installation;
                    break;
                case "repair":
                    employeeSkills = employeeSkillsTypes.repair;
                    break;
                default:
                    employeeSkills = employeeSkillsTypes.installation;
                    break;
            }

            List<Employee> assignableUsers = employeeBusinessLogic.listEmployeesBySkillCategoryAndType(skillCategories, employeeSkills, true);
        }

        private void btnAssignJob_Click(object sender, EventArgs e)
        {

        }
    }
}
