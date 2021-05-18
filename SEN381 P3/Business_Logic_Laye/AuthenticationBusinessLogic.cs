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
    public class AuthenticationBusinessLogic
    {
        private DBAccess db = new DBAccess();

        public Dictionary<string, string> Authenticate(string userName, string password)
        {
            DataTable dataTable = db.Authenticate(userName, password);

            Dictionary<string, string> userAuthDetails = new Dictionary<string, string>();
            userAuthDetails["id"] = "Please enter id here";
            userAuthDetails["userType"] = "Please enter userType here";

            return userAuthDetails;
        }//Remove bottom one and change code to work with auth instead

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
