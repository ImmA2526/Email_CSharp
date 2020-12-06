using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Email
{
    class EmailVerification
    {
        public static string EmailID = "^[a-zA-Z0-9]+[.(a-zA-Z0-9)]*(\\@)[a-zA-Z0-9]+(\\.)[a-z]{2,4}$";
        public bool Emails(string Email)
        {
            Regex Em = new Regex(EmailID);
            bool Validate = Em.IsMatch(Email);
            return Validate;
        }
    }
}
