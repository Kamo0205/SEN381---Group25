using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace PresentationLayer
{
    public partial class FrmCallCenter : Form
    {
        public FrmCallCenter()
        {
            InitializeComponent();

        }

        private void btnMakeCall_Click(object sender, EventArgs e)
        {
            
        }

        private void btnLeaveCall_Click(object sender, EventArgs e)
        {

        }

        private void btnClientScreen_Click(object sender, EventArgs e)
        {
            Clients_Screen clientsScreen = new Clients_Screen();
            this.Hide();
            clientsScreen.ShowDialog();
            this.Close();
        }
    }
}
