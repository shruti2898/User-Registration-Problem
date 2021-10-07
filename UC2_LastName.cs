using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace RegexProblems
{
	class UC2_LastName
	{
		// last name should start with a capital alphabet and has minimum 3 characters(including capital alphabet)

		public static string Regex_LastName = "^[A-Z][a-z]{2,}$";

		public bool validateLastName(string lastName)
		{
			return Regex.IsMatch(lastName, Regex_LastName);
		}
	}
}
