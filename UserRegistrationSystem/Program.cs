using System;
using System.Text.RegularExpressions;

namespace UserRegistrationSystem
{
    public class Program
    {
        public static string firstName, lastName, email, mobileNumber, password;
        public static void Main(string[] args)
        {
            Console.WriteLine("User Registration");
            Console.WriteLine("UC 1 Enter First Name");
            firstName = Console.ReadLine();
            FirstNameCheck(firstName);
            Console.WriteLine("UC 2 Enter Last Name");
            lastName = Console.ReadLine();
            LastNameCheck(lastName);
            Console.WriteLine("UC 3 and 9 Enter Email");
            email = Console.ReadLine();
            EmailCheck(email);
            Console.WriteLine("UC 4 Enter Mobile Number ");
            mobileNumber = Console.ReadLine();
            MobileNumberCheck(mobileNumber);
            Console.WriteLine("UC 5 to 8 Enter Password");
            password = Console.ReadLine();
            PasswordCheck(password);

        }
        //UC 1 First Name
        public static bool FirstNameCheck(string fname)
        {
            var result = Regex.Match(fname, "^[A-Z][a-z]{3,}$").Success;
            if (result)
            {
                Console.WriteLine("Success");
                return true;
            }
            else
            {
                Console.WriteLine("Failed");
                return false;
            }

        }

        //UC 2 Last Name
        public static bool LastNameCheck(string lname)
        {
            var result = Regex.Match(lname, "^[A-Z][a-z]{3,}$").Success;
            if (result)
            {
                Console.WriteLine("Success");
                return true;
            }
            else
            {
                Console.WriteLine("Failed");
                return false;
            }

        }
        //UC 3 and 9 Email
        public static bool EmailCheck(string mail)
        {
            var result = Regex.Match(mail, @"^([\w-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([\w-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$").Success;
            if (result)
            {
                Console.WriteLine("Success");
                return true;
            }
            else
            {
                Console.WriteLine("Failed");
                return false;
            }

        }
        //UC 4 Mobile Number
        public static bool MobileNumberCheck(string mobileNumber)
        {
            var result = Regex.Match(mobileNumber, @"^([0-9]{2})\s([0-9]{10})$").Success;
            if (result)
            {
                Console.WriteLine("Success");
                return true;
            }
            else
            {
                Console.WriteLine("Failed");
                return false;
            }

        }
        //UC 5 Password
        public static bool PasswordCheck(string password)
        {
            var result = Regex.Match(password, @"^([A-Za-z]{5,})([`~!@#$%^&*()_+=:;.,'<>/|\?]{1})([0-9]{1,})$").Success;
            if (result)
            {
                Console.WriteLine("Success");
                return true;
            }
            else
            {
                Console.WriteLine("Failed");
                return false;
            }

        }
    }

}