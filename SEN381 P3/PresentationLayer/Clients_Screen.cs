using Business_Logic_Layer;
using Data_Access_Layer;
using Presentation_Layer;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace PresentationLayer
{
    public partial class Clients_Screen : Form
    {
        BindingSource contractBind = new BindingSource();
        ContractBusinessLogic contractData = new ContractBusinessLogic();
        ClientBusinessLogic clientData = new ClientBusinessLogic();

        public Clients_Screen()
        {
            InitializeComponent();
        }

        private void populateSearchBy()
        {
            cmbSearchBy.Items.Add(new ComboBoxItem(name: "Email", id: 0));
            cmbSearchBy.Items.Add(new ComboBoxItem(name: "Address", id: 1));
            cmbSearchBy.Items.Add(new ComboBoxItem(name: "Phone Number", id: 2));
            cmbSearchBy.Items.Add(new ComboBoxItem(name: "Contract ID", id: 3));
            cmbSearchBy.DisplayMember = "Name";
            cmbSearchBy.ValueMember = "Id";
        }

        private void populateService()
        {
            cmbService.Items.Add(new ComboBoxItem(name: "Bronze", id: 0));
            cmbService.Items.Add(new ComboBoxItem(name: "Silver", id: 1));
            cmbService.Items.Add(new ComboBoxItem(name: "Premium", id: 2));
            cmbService.DisplayMember = "Name";
            cmbService.ValueMember = "Id";
        }

        private void Contract_Screen_Load(object sender, EventArgs e)
        {
            lstData.DataSource = contractBind;
            populateSearchBy();
            populateService();
        }

        private void txtClientId_TextChanged(object sender, EventArgs e)
        {
      
        }

        private void txtSearchParamater_TextChanged(object sender, EventArgs e)
        {
            serviceLevel selectedService = (serviceLevel)cmbService.SelectedIndex;
            clientSearchParameter searchParameter = (clientSearchParameter)cmbSearchBy.SelectedIndex;

            List<Client> searchResults = clientData.searchClientByParameter(parameter: searchParameter, query: txtSearchParamater.Text, serviceLevel: selectedService);
            if (searchResults.Count > 0)
            {
                Client client = searchResults[0];

                txtClientFirstName.Text = client.FirstName;
                txtClientLastName.Text = client.LastName;
                txtClientLocation.Text = client.Address;
                txtClientPhoneNumber.Text = client.PhoneNumber;
                txtClientEmail.Text = client.Email;

                List<Contract> selectedClientContracts = contractData.searchContractsByID(id: client.ContractID);

                contractBind.DataSource = selectedClientContracts;
            }
        }

        private void lstData_SelectedIndexChanged(object sender, EventArgs e)
        {
            Contract selectedContract = (Contract)lstData.SelectedItem;

            txtContractId.Text = selectedContract.ID;
            txtContractExperationDate.Text = selectedContract.ExperationDate;
            txtContractServiceLevel.Text = selectedContract.ServiceLevel;
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            contractBind.MovePrevious();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            contractBind.MoveNext();
        }
    }
}
