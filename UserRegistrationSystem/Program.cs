using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace UserRegistrationSystem
{
    public class Program
    {
        public static void Main(string[] args)
        {

            //UC 13
            Console.WriteLine("User Registration Validating using Regular Expression!");
            RegexSample regexSample = new RegexSample();
            regexSample.Validating();

        }


    }
}