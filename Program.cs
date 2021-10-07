using System;
using System.Collections.Generic;

namespace RegexProblems
{
    class Program
    {
        static void Main(string[] args)
        {
            #region UC1 firstname
            UC1_FirstName uc1 = new UC1_FirstName();
            bool ucTest1 = uc1.validateFirstName("Shruti");
            bool ucTest2 = uc1.validateFirstName("12Shruti");
            bool ucTest3 = uc1.validateFirstName("shruti");
            Console.WriteLine("{0} {1} {2}", (ucTest1) ? "Valid" : "Invalid", (ucTest2) ? "Valid" : "Invalid", (ucTest3) ? "Valid" : "Invalid");
            #endregion

            #region UC2 lastname
            UC2_LastName uc2 = new UC2_LastName();
            bool uc2Test1 = uc2.validateLastName("Verma");
            bool uc2Test2 = uc2.validateLastName("12Verma");
            bool uc2Test3 = uc2.validateLastName("verma");
            Console.WriteLine("{0} {1} {2}",(uc2Test1) ? "Valid" : "Invalid" , (uc2Test2) ? "Valid" : "Invalid" ,(uc2Test3) ? "Valid" : "Invalid");
            #endregion


            #region UC3 Email
            UC3_Email uc3 = new UC3_Email();
            bool uc3Test1 = uc3.validateEmail("abc.xyz@bl.co.in");
            bool uc3Test2 = uc3.validateEmail("abc.xyz@in");
            bool uc3Test3 = uc3.validateEmail("abc.@bl.co.in");
            Console.WriteLine("{0} {1} {2}", (uc3Test1) ? "Valid" : "Invalid", (uc3Test2) ? "Valid" : "Invalid", (uc3Test3) ? "Valid" : "Invalid");
            #endregion


            #region UC4 Mobile Number
            UC4_MobileNumber uc4 = new UC4_MobileNumber();
            bool uc4Test1 = uc4.validateMobileNumber("91 9876543210");
            bool uc4Test2 = uc4.validateMobileNumber("12345678");
            bool uc4Test3 = uc4.validateMobileNumber("123abcd");
            Console.WriteLine("{0} {1} {2}", (uc4Test1) ? "Valid" : "Invalid", (uc4Test2) ? "Valid" : "Invalid", (uc4Test3) ? "Valid" : "Invalid");
            #endregion


            #region UC5 Password1
            UC5_PasswordRule1 uc5 = new UC5_PasswordRule1();
            bool uc5Test1 = uc5.validatePassword("1234pass");
            bool uc5Test2 = uc5.validatePassword("123ab");
            bool uc5Test3 = uc5.validatePassword("123abced12");
            Console.WriteLine("{0} {1} {2}", (uc5Test1) ? "Valid" : "Invalid", (uc5Test2) ? "Valid" : "Invalid", (uc5Test3) ? "Valid" : "Invalid");
            #endregion


            #region UC6 Password2
            UC6_PasswordRule2 uc6 = new UC6_PasswordRule2();
            bool uc6Test1 = uc6.validatePassword("A123abcd");
            bool uc6Test2 = uc6.validatePassword("12345678");
            bool uc6Test3 = uc6.validatePassword("abcd");
            Console.WriteLine("{0} {1} {2}", (uc6Test1) ? "Valid" : "Invalid", (uc6Test2) ? "Valid" : "Invalid", (uc6Test3) ? "Valid" : "Invalid");
            #endregion


            #region UC7 Password3
            UC7_PasswordRule3 uc7 = new UC7_PasswordRule3();
            bool uc7Test1 = uc7.validatePassword("1243abcd");
            bool uc7Test2 = uc7.validatePassword("15678");
            bool uc7Test3 = uc7.validatePassword("Abccdabcd");
            Console.WriteLine("{0} {1} {2}", (uc7Test1) ? "Valid" : "Invalid", (uc7Test2) ? "Valid" : "Invalid", (uc7Test3) ? "Valid" : "Invalid");
            #endregion


            #region UC8 Password4
            UC8_PasswordRule4 uc8 = new UC8_PasswordRule4();
            bool uc8Test1 = uc8.validatePassword("abc@12356");
            bool uc8Test2 = uc8.validatePassword("@123abcd");
            bool uc8Test3 = uc8.validatePassword("123abcd");
            Console.WriteLine("{0} {1} {2}", (uc8Test1) ? "Valid" : "Invalid", (uc8Test2) ? "Valid" : "Invalid", (uc8Test3) ? "Valid" : "Invalid");
            #endregion



            #region UC9 Email
            UC9_EmailSample sample = new UC9_EmailSample();
            List<string> tests = new List<string>() {"abc@yahoo.com", "abc-100@yahoo.com", "abc.100@yahoo.com", "abc111@abc.com", "abc-100@abc.net", "abc.100@abc.com.au", "abc@1.com", "abc@gmail.com.com", "abc+100@gmail.com" ,
                                                     "abc","abc@.com.my","abc123@gmail.a","abc123@.com","abc123@.com.com",".abc@abc.com","abc()*@gmail.com","abc@%*.com","abc..2002@gmail.com","abc.@gmail.com","abc@abc@gmail.com","abc@gmail.com.1a","abc@gmail.com.aa.au"};
           
            foreach(var test in tests)
            {
                bool result = sample.validateEmail(test);
                if (result)
                {
                    Console.WriteLine("\n{0} is a valid email address",test);
                }
                else
                {
                    Console.WriteLine("\n{0} is an invalid email address", test);
                }
            }
            #endregion

            Console.ReadKey();
        }
    }
}
