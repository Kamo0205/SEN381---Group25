using System;
using System.Windows.Forms;

namespace PresentationLayer
{
    public partial class FrmServiceDepartment : Form
    {
        BindingSource employeeBind = new BindingSource();

        public FrmServiceDepartment(string contractId)
        {
            InitializeComponent();
        }

        private void lstTechnicians_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void FrmServiceDepartment_Load(object sender, EventArgs e)
        {

        }
    }
}
