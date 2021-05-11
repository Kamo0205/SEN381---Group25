using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using Business_Logic_Layer;

namespace PresentationLayer
{
    public partial class Contract_Screen : Form
    {
        BindingSource contractBind = new BindingSource();
        //ContractBusinessLogic contractData = new ContractBusinessLogic();


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
