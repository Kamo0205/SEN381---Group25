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
            try
            {
                DataTable authenticationData = db.Authenticate(userName, password);

                Dictionary<string, string> userAuthDetails = new Dictionary<string, string>();
                if (authenticationData.Rows.Count > 1)
                {
                    MessageBox.Show("Authentication error two or more users have the same email!");
                    return null;
                }
                else
                {
                    userAuthDetails["id"] = authenticationData.Rows[0]["AuthenticationID"].ToString();
                    userAuthDetails["userType"] = authenticationData.Rows[0]["UserType"].ToString();
                    return userAuthDetails;
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("AuthenticationBusinessLogic : getUserTypeAndID ERROR:" + e.Message);
                throw;
            }
            
        }

        public char cipher(char ch, int key)
        {
            if (!char.IsLetter(ch))
            {
                return ch;
            }

            char d = char.IsUpper(ch) ? 'A' : 'a';
            return (char)((((ch + key) - d) % 26) + d);
        }

        public string Encipher(string input, int key)
        {
            string output = string.Empty;

            foreach (char ch in input)
                output += cipher(ch, key);

            return output;
        }
    }
}
