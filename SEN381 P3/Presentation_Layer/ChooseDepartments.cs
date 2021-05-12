using System;
using System.Windows.Forms;

namespace PresentationLayer
{
    public partial class FrmChooseDepartments : Form
    {
        public FrmChooseDepartments()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            FrmWelcomeScreen home = new FrmWelcomeScreen();
            this.Hide();
            home.ShowDialog();
            this.Close();
        }
    }
}
