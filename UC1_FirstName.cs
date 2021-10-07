using System.Text.RegularExpressions;

namespace RegexProblems
{
	class UC1_FirstName
	{   
		// first name should start with a capital alphabet and has minimum 3 characters(including capital alphabet)
		public static string Regex_FirstName = "^[A-Z][a-z]{2,}$";

		public bool validateFirstName(string firstName)
		{
			return Regex.IsMatch(firstName, Regex_FirstName); 
		}
	}
}
