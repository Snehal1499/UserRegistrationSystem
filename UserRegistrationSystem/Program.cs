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
        //UC 2 Last Name
        public string isMatchLastName(string lastName)
        {
            try
            {
                if (Regex.Match(lastName, "^[A-Z][a-z]{3,}$").Success)
                {
                    Console.WriteLine("Success , Last Name is : " + lastName);
                }
                else
                {
                    Console.WriteLine("Failed");
                    throw new Exception();
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Last Name should Start with Upper Case Letter and minimum charecters should be 3 ");
            }
            return lastName;

        }
        //UC 3 and 9 Email
        public string isMatchEmail(string email)
        {
            try
            {
                if (Regex.Match(email, @"^([\w-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([\w-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$").Success)
                {
                    Console.WriteLine("Success , Email is : " + email);
                }
                else
                {
                    Console.WriteLine("Failed");
                    throw new Exception();
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Email \nEx abc.xyz@bl.co.in\nEmail should have 3 mandatory Parts(abc,bl&co)with precise @ and . postions");
            }
            return email;
        }

    }

}