using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Business_Logic_Layer;
using Data_Access_Layer;

namespace Presentation_Layer
{
    public partial class RegisterScreen : Form
    {
        public RegisterScreen()
        {
            InitializeComponent();
        }

        private ClientBusinessLogic clientLogic = new ClientBusinessLogic();

        bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }

        bool IsPhoneNumber(string number)
        {
            return Regex.Match(number, @"^(\+[0-9]{9})$").Success;
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (!IsValidEmail(txtEmail.Text))
            {
                MessageBox.Show("Please enter a valid email address");
            }
            if (!IsPhoneNumber(txtContactNumber.Text))
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
            if (txtAddress.Text.Length < 10)
            {
                MessageBox.Show("Please enter a valid address");
            }
            if (txtPassword.Text != txtConfirmPassword.Text)
            {
                MessageBox.Show("Password do not match");
            }
            if(IsValidEmail(txtEmail.Text) && IsPhoneNumber(txtContactNumber.Text) && txtAddress.Text.Length > 10 && txtSurname.Text.Length > 3 && txtName.Text.Length > 3 && txtPassword.Text == txtConfirmPassword.Text)
            {
                clientLogic.createClient(new Bronze(id: null, firstName: txtName.Text, lastName: txtSurname.Text,phoneNumber: txtContactNumber.Text, address: txtAddress.Text, email: txtEmail.Text), txtPassword.Text);
            }
        }
    }
}
