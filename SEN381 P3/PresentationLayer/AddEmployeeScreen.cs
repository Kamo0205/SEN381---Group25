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

        public void populateEmployeeType()
        {
            cmbEmployeeType.Items.Add(new ComboBoxItem(name: "CallCentre", id: 0));
            cmbEmployeeType.Items.Add(new ComboBoxItem(name: "Technician", id: 0));
            cmbEmployeeType.DisplayMember = "Name";
            cmbEmployeeType.ValueMember = "Id";
        }

        private void btnAddEmployee_Click(object sender, EventArgs e)
        {
            if (!validator.IsValidEmail(txtEmail.Text))
            {
                MessageBox.Show("Please enter a valid email address");
            }
            if (txtContactNumber.TextLength < 10)
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
            if (cmbEmployeeType.SelectedIndex == -1)
            {
                MessageBox.Show("Please select an employee type");
            }
            if (validator.IsValidEmail(txtEmail.Text) && txtContactNumber.TextLength >= 10 && txtVATID.Text.Length >= 10 && txtSurname.Text.Length >= 3 && txtName.Text.Length >= 3 && txtPassword.Text == txtConfirmPassword.Text && cmbEmployeeType.SelectedIndex >= 0)
            {
                if (cmbEmployeeType.SelectedIndex == 0)
                {
                    employeeLogic.addEmplpoyee(employee: new CallCenterStaff(id: null, firstName: txtName.Text, lastName: txtSurname.Text, phoneNumber: txtContactNumber.Text, email: txtEmail.Text, new Pay("", 600), vatID: txtVATID.Text), password: txtPassword.Text, type: cmbEmployeeType.Text);
                    MessageBox.Show(string.Format("Call Centre Staff {0} {1} created!", txtName.Text, txtSurname.Text));
                }
                else
                {
                    AuthenticationBusinessLogic authenticationBusinessLogic = new AuthenticationBusinessLogic();
                    employeeLogic.addEmplpoyee(employee: new TechnicalStaff(id: null, firstName: txtName.Text, lastName: txtSurname.Text, phoneNumber: txtContactNumber.Text, email: txtEmail.Text, new Pay("", 600), vatID: txtVATID.Text), password: authenticationBusinessLogic.Encipher(txtPassword.Text, 12), type: cmbEmployeeType.Text);
                    MessageBox.Show(string.Format("Technician {0} {1} created!", txtName.Text,txtSurname.Text));
                }
            }
        }

        private void AddEmployeeScreen_Load(object sender, EventArgs e)
        {
            populateEmployeeType();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
