using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Data_Access_Layer;

namespace Business_Logic_Layer
{
    class AuthenticationBusinessLogic
    {
        private DBAccess db = new DBAccess();

        public List<string> getUserTypeAndID(string email, string password)
        {
            try
            {
                List<string> IdAndType = new List<string>();
                DataTable authenticationData = db.Authenticate(email,password);
                if(authenticationData.Rows.Count > 1)
                {
                    MessageBox.Show("Authentication error two or more users have the same email!");
                    return null;
                }
                else
                {
                    IdAndType.Add(authenticationData.Rows[0]["AuthenticationID"].ToString());
                    IdAndType.Add(authenticationData.Rows[0]["UserType"].ToString());
                    return IdAndType;
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("AuthenticationBusinessLogic : getUserTypeAndID ERROR:" + e.Message);
                throw;
            }
        }
    }
}
