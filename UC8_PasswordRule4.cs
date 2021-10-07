using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace RegexProblems
{
    class UC8_PasswordRule4
    {  
        // A password should have exactly one special character
        public static string Regex_Password = "(?=.*[!@#$%^&*]{,1})(?=.[A-Za-z]{7,})";

        public bool validatePassword(string password)
        {
            return Regex.IsMatch(password, Regex_Password);
        }
    }
}
