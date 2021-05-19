using System.Collections.Generic;
using System.Windows.Forms;
using Business_Logic_Layer;
using Data_Access_Layer;

namespace Presentation_Layer
{
    public partial class EmployeePage : Form
    {
        private Employee selectedStaff;

        public EmployeePage(Employee technicalStaff)
        {
            InitializeComponent();

            this.selectedStaff = technicalStaff;

            txtName.Text = technicalStaff.FirstName;
            txtEmail.Text = technicalStaff.Email;
            txtSurname.Text = technicalStaff.LastName;
            txtNum.Text = technicalStaff.Address;
        }

        private void btnSave_Click(object sender, System.EventArgs e)
        {
            EmployeeBusinessLogic employeeBusiness = new EmployeeBusinessLogic();

            selectedStaff.FirstName = txtName.Text;
            selectedStaff.Email = txtEmail.Text;
            selectedStaff.LastName  = txtSurname.Text;
            selectedStaff.Address = txtNum.Text;

            employeeBusiness.updateEmployee(selectedStaff, employeeType.technician);
        }

        private string ShowSkillDialog()
        {
            EmployeeBusinessLogic employeeBusiness = new EmployeeBusinessLogic();
            List<Skill> employeeSkils = employeeBusiness.getEmployeeSkills(selectedStaff);

            List<string> currentSkills = new List<string>();

            foreach (Skill skill in employeeSkils)
            {
                currentSkills.Add(skill.ID);
            }

            List<string> newSkills = employeeBusiness.listAllSkills(currentSkills);

            Form prompt = new Form()
            {
                Width = 500,
                Height = 150,
                FormBorderStyle = FormBorderStyle.FixedDialog,
                Text = "Please enter your new skill name",
                StartPosition = FormStartPosition.CenterScreen
            };
            Label lblPassword = new Label() { Left = 50, Top = 20, Text = "New Skill" };
            ComboBox cmbSkills = new ComboBox() { Left = 50, Top = 50, Width = 400 };

            int count = 0;

            foreach (string item in newSkills)
            {
                cmbSkills.Items.Add(new ComboBoxItem(item, count));
                count++;
            }

            Button confirmation = new Button() { Text = "Ok", Left = 350, Width = 100, Top = 70, DialogResult = DialogResult.OK };
            confirmation.Click += (sender, e) => { prompt.Close(); };
            prompt.Controls.Add(cmbSkills);
            prompt.Controls.Add(confirmation);
            prompt.Controls.Add(lblPassword);
            prompt.AcceptButton = confirmation;

            return prompt.ShowDialog() == DialogResult.OK ? cmbSkills.Name : "";
        }

        private void btnExit_Click(object sender, System.EventArgs e)
        {
            this.Hide();
        }

        private void button1_Click(object sender, System.EventArgs e)
        {
            string skillID = ShowSkillDialog();

            EmployeeBusinessLogic employeeBusiness = new EmployeeBusinessLogic();
            employeeBusiness.addSkillForEmployee(selectedStaff.Id, skillID);
        }
    }
}
