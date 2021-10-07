using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace RegexProblems
{
    class UC9_EmailSample
    {
        /* 1. Email username should start with alphabet - [a-z]
           2. Username may have digits and alphabets   [a-z0-9]
           3. Username must have at least 3 characters  [a-z][a-z0-9]{2,}   
           4. Email address may have a sub username which is connected by a .,-,+ with username (eg. xyz.abc@gmail.com) and has 3 characters  ([-.+]{1}[a-z0-9]{3})?
           5. Email address should have exactly one @ symbol after username and before domain 
           6. Second level domain should have at least one character and followed by a dot [a-z0-9]{1,}[.]
           7. Email address may have a third level domain and it should have at least 3 characters 
           8. Top level domain should have exactly 3 characters  [a-z]{3}
           9. Email address may have country level domain and it should have 2 or 3 characters.  [a-z]{2,3}
           10. Each domain level should be separated by a dot.
        */
        public static string Regex_Email = "^[a-z][a-z0-9]{2,}([-.+]{1}[a-z0-9]{3})?[@][a-z0-9]{1,}[.][a-z]{3}([.][a-z]{2,3})?$";                                                                                     

        public bool validateEmail(string email)
        {
            return Regex.IsMatch(email, Regex_Email);
        }
    }
}
