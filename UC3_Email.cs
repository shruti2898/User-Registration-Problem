using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace RegexProblems
{
	class UC3_Email
	{
		// Email has 3 mandatory parts (abc, bl & co) and 2 optional(xyz & in) with precise @ and. positions
		//E.g. abc.xyz@bl.co.in
		public static string Regex_Email = "^[A-Za-z]{3,}([.][A-Za-z]{3,})?[@][A-Za-z]{2,}([.][A-Za-z]{2})?$";

		public bool validateEmail(string email)
		{
			return Regex.IsMatch(email, Regex_Email);
		}
	}
}
