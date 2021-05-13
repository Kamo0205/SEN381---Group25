using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentation_Layer
{
    public class Prompt
    {
        public void ShowDialog(string message, string caption, Action method)
        {
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result;

            result = MessageBox.Show(message, caption, buttons);
            if (result == DialogResult.Yes)
            {
                method();
            }
        }

    }
}
