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

        private void btnEXIT_Click(object sender, EventArgs e)
        {
            FrmClientSatisfaction clientSatisfaction = new FrmClientSatisfaction(selectedClient);
            this.Hide();
            clientSatisfaction.Show();
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
    }
}
