using Business_Logic_Layer;
using System;
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

        }

        private void txtClientId_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
