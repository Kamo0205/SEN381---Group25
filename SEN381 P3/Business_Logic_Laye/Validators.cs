using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Business_Logic_Layer
{
    public class Validators
    {
        public bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }

        public bool IsPhoneNumber(string number)
        {
            return Regex.Match(number, @"^(\+[0-9]{9})$").Success;
        }
    }
}
