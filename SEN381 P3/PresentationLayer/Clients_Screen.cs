using Business_Logic_Layer;
using Data_Access_Layer;
using Presentation_Layer;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Presentation_Layer
{
    public partial class Clients_Screen : Form
    {
        private BindingSource contractBind = new BindingSource();
        private ContractBusinessLogic contractData = new ContractBusinessLogic();
        private ClientBusinessLogic clientData = new ClientBusinessLogic();

        private List<Client> searchResults = new List<Client>();
        private Prompt prompt = new Prompt();
        private DateTime dDate;
        private bool isClient = false;

        public Clients_Screen(Client client = null)
        {
            InitializeComponent();
            if (client != null)
            {
                lblSearchCLients.Hide();
                lblSearchBy.Hide();
                lblService.Hide();
                cmbSearchBy.Hide();
                cmbService.Hide();
                cmbServiceChange.AllowDrop = false;
                txtSearchParamater.Hide();
                txtContractExperationDate.ReadOnly = true;
                btnContractAdd.Hide();
                btnContractUpdate.Hide();
                btnContractDelete.Hide();
                List<Contract> selectedClientContracts = contractData.listContractsBySearchParamater(parameter: contractSearchParamaters.id, query: client.Id);
                contractBind.DataSource = selectedClientContracts;
                this.isClient = true;
            }
        }

        private void populateSearchBy()
        {
            cmbSearchBy.Items.Add(new ComboBoxItem(name: "Email", id: 0));
            cmbSearchBy.Items.Add(new ComboBoxItem(name: "Address", id: 1));
            cmbSearchBy.Items.Add(new ComboBoxItem(name: "Phone Number", id: 2));
            cmbSearchBy.DisplayMember = "Name";
            cmbSearchBy.ValueMember = "Id";
        }

        private void populateService()
        {
            List<ComboBoxItem> items = new List<ComboBoxItem>{new ComboBoxItem(name: "Bronze", id: 0), new ComboBoxItem(name: "Silver", id: 1), new ComboBoxItem(name: "Premium", id: 2)};
            foreach (ComboBoxItem item in items)
            {
                cmbService.Items.Add(item);
                cmbServiceChange.Items.Add(item);
            };
            cmbService.DisplayMember = "Name";
            cmbService.ValueMember = "Id";
            cmbServiceChange.DisplayMember = "Name";
            cmbServiceChange.ValueMember = "Id";
        }

        private void Contract_Screen_Load(object sender, EventArgs e)
        {
            lstData.DataSource = contractBind;
            populateSearchBy();
            populateService();
        }

        private void txtSearchParamater_TextChanged(object sender, EventArgs e)
        {
            clientSearchParameter searchParameter = (clientSearchParameter)cmbSearchBy.SelectedIndex;

            searchResults = clientData.searchClientByParameter(parameter: searchParameter, query: txtSearchParamater.Text);
            if (searchResults != null)
            {
                Client client = searchResults[0];

                txtClientFirstName.Text = client.FirstName;
                txtClientLastName.Text = client.LastName;
                txtClientLocation.Text = client.Address;
                txtClientPhoneNumber.Text = client.PhoneNumber;
                txtClientEmail.Text = client.Email;

                List<Contract> selectedClientContracts = contractData.listContractsBySearchParamater(parameter: contractSearchParamaters.clientID,query: client.Id);

                contractBind.DataSource = selectedClientContracts;
            }
        }

        private void lstData_SelectedIndexChanged(object sender, EventArgs e)
        {
            Contract selectedContract = (Contract)lstData.SelectedItem;

            txtContractId.Text = selectedContract.Id;
            txtContractExperationDate.Text = selectedContract.ExperationDate;
            cmbServiceChange.Text = selectedContract.ServiceLevel;
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            contractBind.MovePrevious();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            contractBind.MoveNext();
        }

        private void btnContractDelete_Click(object sender, EventArgs e)
        {
            if(txtContractId.Text == "")
            {
                MessageBox.Show("No contract is currently selected");
            }
            else
            {
                prompt.ShowDialog(message: "Are you sure you want to delete this Contract?", caption: "Delete Contract?", method: () => contractData.deleteContract(id: txtContractId.Text));
            }
            
        }

        private void btnContractUpdate_Click(object sender, EventArgs e)
        {
            if (txtContractId.Text == "")
            {
                MessageBox.Show("No contract is currently selected");
            }
            else
            {
                if (DateTime.TryParse(txtContractExperationDate.Text, out dDate))
                {
                    contractData.updateContract(new Contract(id: txtContractId.Text, clientID: searchResults[0].Id,serviceLevel: cmbServiceChange.Text, experationDate: txtContractExperationDate.Text));
                    MessageBox.Show("Contract Updated!");
                }
                else
                {
                    MessageBox.Show("Invalid Experation Date");
                }
            }
            
        }

        private void btnContractAdd_Click(object sender, EventArgs e)
        {
            if (searchResults.Count == 0)
            {
                MessageBox.Show("Please select a client to assign the contract to");
            }
            else
            {
                if (DateTime.TryParse(txtContractExperationDate.Text, out dDate))
                {
                    Contract newContract = new Contract(id: null, clientID: searchResults[0].Id, serviceLevel: cmbServiceChange.Text, experationDate: txtContractExperationDate.Text);
                    contractData.createContract(newContract);
                    MessageBox.Show(string.Format("Created contract for {0} {1}!", txtClientFirstName.Text, txtClientLastName.Text));
                }
                else
                {
                    MessageBox.Show("Invalid Experation Date");
                }
            }
        }

        private void btnJobScreen_Click(object sender, EventArgs e)
        {
            if(txtContractId.Text == "")
            {
                MessageBox.Show("Please select a contract to assign the job to");
            }
            else
            {
                if (!this.isClient)
                {
                    FrmServiceDepartment serviceDepartment = new FrmServiceDepartment(contractData.listContractsBySearchParamater(contractSearchParamaters.id, txtContractId.Text)[0]);
                    this.Hide();
                    serviceDepartment.Show();
                }
                else
                {
                    JobStatusScreen jobStatusScreen = new JobStatusScreen();
                    this.Hide();
                    jobStatusScreen.Show();
                }
                
            }
        }
    }
}
