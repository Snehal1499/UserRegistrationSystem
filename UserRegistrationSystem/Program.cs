using System;
using System.Text.RegularExpressions;

namespace UserRegistrationSystem
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome TO User Registration System");
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
        //UC 4 Mobile Number
        public string isMatchMobileNumber(string mobileNumber)
        {
            try
            {
                if (Regex.Match(mobileNumber, @"^([0-9]{2})\s([0-9]{10})$").Success)
                {
                    Console.WriteLine("Success , Mobile Number is : " + mobileNumber);
                }
                else
                {
                    Console.WriteLine("Failed");
                    throw new Exception();
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Mobile Number Should have 2 number for Country code followed by space and 10 digit number ");
            }
            return mobileNumber;

        }
        //UC 5,6,7,8 Password
        public string isMatchPassword(string password)
        {
            try
            {
                if (Regex.Match(password, @"^([A-za-z]{5,})([@~!`#$%^&*]{1})([0-9]{1,})$").Success)
                {
                    Console.WriteLine("Success , Password is : " + password);
                }
                else
                {
                    Console.WriteLine("Failed");
                    throw new Exception();
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Password Should have \n1)minimum 8 characters\n2)Atleast 1 UpperCase letter\n3)Atleast 1 number\n4)exactly 1 Special Charecter\n5)");
            }
            return password;

        }
    }

}