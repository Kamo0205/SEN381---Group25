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
    public partial class ClientPage : Form
    {
        private Client selectedClient;

        public ClientPage(Client client)
        {
            InitializeComponent();
            this.selectedClient = client;

            txtName.Text = client.FirstName;
            txtEmail.Text = client.Email;
            txtSurname.Text = client.LastName;
            txtAddress.Text = client.Address;
        }

        private string ShowPasswordDialog()
        {
            Form prompt = new Form()
            {
                Width = 500,
                Height = 150,
                FormBorderStyle = FormBorderStyle.FixedDialog,
                Text = "Please enter your new password",
                StartPosition = FormStartPosition.CenterScreen
            };
            Label lblPassword = new Label() { Left = 50, Top = 20, Text = "New Password" };
            TextBox textBox = new TextBox() { Left = 50, Top = 50, Width = 400 };
            Button confirmation = new Button() { Text = "Ok", Left = 350, Width = 100, Top = 70, DialogResult = DialogResult.OK };
            confirmation.Click += (sender, e) => { prompt.Close(); };
            prompt.Controls.Add(textBox);
            prompt.Controls.Add(confirmation);
            prompt.Controls.Add(lblPassword);
            prompt.AcceptButton = confirmation;

            return prompt.ShowDialog() == DialogResult.OK ? textBox.Text : "";
        }

        private void btnEXIT_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
             Validators validator = new Validators();

            if (validator.IsValidEmail(txtEmail.Text) && txtName.Text != "" && txtSurname.Text != "" && txtAddress.Text !=  "") 
            {
                selectedClient.FirstName = txtName.Text;
                selectedClient.Email = txtEmail.Text;
                selectedClient.LastName = txtSurname.Text;
                selectedClient.Address = txtAddress.Text;

                ClientBusinessLogic clientBusiness = new ClientBusinessLogic();
                clientBusiness.updateClient(selectedClient);
            }
        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            string newPassword = ShowPasswordDialog();
            ClientBusinessLogic clientBusiness = new ClientBusinessLogic();
            clientBusiness.updateClientPassword(selectedClient, newPassword);
        }
    }
}
