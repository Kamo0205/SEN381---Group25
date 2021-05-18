using System;
using System.Windows.Forms;
using Data_Access_Layer;
using Business_Logic_Layer;
using Presentation_Layer;

namespace Presentation_Layer
{
    public partial class AddEmployeeScreen : Form
    {
        private EmployeeBusinessLogic employeeLogic = new EmployeeBusinessLogic();
        private Validators validator = new Validators();
        private AuthenticationBusinessLogic authenticationLogic = new AuthenticationBusinessLogic();

        public AddEmployeeScreen()
        {
            InitializeComponent();
        }

        private void btnAddEmployee_Click(object sender, EventArgs e)
        {
            if (!validator.IsValidEmail(txtEmail.Text))
            {
                MessageBox.Show("Please enter a valid email address");
            }
            if (!validator.IsPhoneNumber(txtContactNumber.Text))
            {
                MessageBox.Show("Please enter a valid phone number");
            }
            if (txtName.Text.Length <= 3)
            {
                MessageBox.Show("Please enter a valid name");
            }
            if (txtSurname.Text.Length <= 3)
            {
                MessageBox.Show("Please enter a valid surname");
            }
            if (txtVATID.Text.Length < 10)
            {
                MessageBox.Show("Please enter a valid VAT ID");
            }
            if (txtPassword.Text != txtConfirmPassword.Text)
            {
                MessageBox.Show("Password do not match");
            }
            if (validator.IsValidEmail(txtEmail.Text) && validator.IsPhoneNumber(txtContactNumber.Text) && txtVATID.Text.Length > 10 && txtSurname.Text.Length > 3 && txtName.Text.Length > 3 && txtPassword.Text == txtConfirmPassword.Text)
            {
                //employeeLogic.addEmplpoyee(new Employee());
            }
        }
    }
}
