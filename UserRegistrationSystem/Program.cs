using System;
using System.Text.RegularExpressions;

namespace UserRegistrationDay26
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome To User Registration System");
            Console.WriteLine("UC 1Enter First Name");
            string firstName = Console.ReadLine();
            Program p = new Program();

            p.isMatchFirstName(firstName);

        }
        //UC 1 First Name
        public string isMatchFirstName(string firstName)
        {
            try
            {
                if (Regex.Match(firstName, "^[A-Z][a-z]{3,}$").Success)
                {
                    Console.WriteLine("Success , Firt Name is : " + firstName);
                }
                else
                {
                    Console.WriteLine("Failed");
                    throw new Exception();
                }
            }
            catch (Exception)
            {
                Console.WriteLine("First Name should Start with Upper Case Letter and minimum charecters should be 3 ");
            }
            return firstName;

        }

    }

}
