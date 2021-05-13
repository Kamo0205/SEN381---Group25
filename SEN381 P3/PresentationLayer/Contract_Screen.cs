using Business_Logic_Layer;
using Data_Access_Layer;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace PresentationLayer
{
    public partial class Contract_Screen : Form
    {
        BindingSource contractBind = new BindingSource();
        ContractBusinessLogic contractData = new ContractBusinessLogic();

        public Contract_Screen()
        {
            InitializeComponent();
        }

        private void Contract_Screen_Load(object sender, EventArgs e)
        {
            lstData.DataSource = contractBind;
        }

        private void txtClientId_TextChanged(object sender, EventArgs e)
        {
            try
            {
                List<Contract> searchResults = contractData.searchContractsByID(txtClientId.Text);
                if(searchResults.Count > 0)
                {
                    contractBind.DataSource = searchResults;
                }
                if(txtClientId.Text == "")
                {
                    contractBind.DataSource = new List<string>();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Contract_Screen : txtClientId_TextChanged : " + ex);
                throw;
            }
        }

        private void lstData_SelectedIndexChanged(object sender, EventArgs e)
        {
            Contract selectedContract = (Contract)lstData.SelectedItem;

            txtServiceLevel.Text = selectedContract.ServiceLevel;
            txtExperationDate.Text = selectedContract.ExperationDate;
        }
    }
}
