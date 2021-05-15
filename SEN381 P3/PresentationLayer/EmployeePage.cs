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
    public partial class EmployeePage : Form
    {
        public EmployeePage()
        {
            InitializeComponent();
        }

        private void chEdit_CheckedChanged(object sender, EventArgs e)
        {
            if (chEdit.Checked)
            {
                txtName.Enabled = true;
                txtSurname.Enabled = true;
                txtPassword.Enabled = true;
                txtVatID.Enabled = true;
                txtNum.Enabled = true;
                txtEmail.Enabled = true;
            }
            else
            {
                txtName.Enabled = false;
                txtSurname.Enabled = false;
                txtPassword.Enabled = false;
                txtVatID.Enabled = false;
                txtNum.Enabled = false;
                txtEmail.Enabled = false;
            }
        }
    }
}
