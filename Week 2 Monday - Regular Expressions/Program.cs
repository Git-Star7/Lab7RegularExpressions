using System;
using System.Text.RegularExpressions;

namespace Week_2_Monday___Regular_Expressions
{
    class Program
    {
        static void Main(string[] args)
        {
            //calls each method using the GetUserInput method for the input
            IsName(GetUserInput("What's your first and last name?  ( Jonny Appleseed )"));
            IsEmail(GetUserInput("Give me an email address  ( jonnyappleseed@gmail.com )"));
            IsPhoneNumber(GetUserInput("Give me a phone number  ( 123-456-7890 )"));
            IsDate(GetUserInput("Enter a date  ( dd/mm/yyyy )"));
        }

        //gets user input and displays a message
        public static string GetUserInput(string message)
        {
            Console.WriteLine(message);
            string input = Console.ReadLine();
            return input;
        }

        //checks for a name input (first and last name required)
        public static void IsName(string message)
        {
            if (Regex.IsMatch(message, @"^\b[A-Z][a-z]{1,29}\b \b[A-Z][a-z]{1,29}\b$"))
            {
                Console.WriteLine("This is a name");
            }
            else
            {
                Console.WriteLine("Invalid Input");
                IsName(GetUserInput("What's your first and last name?  ( Jonny Appleseed )"));
            }
        }

        //checks for an email input
        public static void IsEmail(string message)
        {
            if (Regex.IsMatch(message, @"^\b[A-z0-9]{5,30}\@[A-z0-9]{5,10}\.[A-z0-9]{2,3}\b$"))
            {
                Console.WriteLine("This is an email address");
            }
            else
            {
                Console.WriteLine("Invalid Input");
                IsEmail(GetUserInput("Give me an email address  ( jonnyappleseed@gmail.com )"));
            }
        }

        //checks if input is a phone number in the 123-123-1234 format
        public static void IsPhoneNumber(string message)
        {
            if (Regex.IsMatch(message, @"^\b\d{3}-\d{3}-\d{4}\b$"))
            {
                Console.WriteLine("This is a phone number.");
            }
            else
            {
                Console.WriteLine("Invalid Input");
                IsPhoneNumber(GetUserInput("Give me a phone number  ( 123-456-7890 )"));
            }
        }

        //checks for a date input in the dd/mm/yyyy format. d/m/yyyy is also acceptable
        public static void IsDate(string message)
        {
            if (Regex.IsMatch(message, @"^\b((([0-2]*[0-9]|[3][01])[/]([1][02]|[0]*[13578]))|(([0-2]*[0-9]|[3][00])[/]([0]*[469]|[1][1]))|(([0-2]*[0-8]|[01]*[9])[/]([0]*[2])))[/]\d{4}\b$")) //I made this myself :) it ain't much, but it's honest work.
            {
                Console.WriteLine("This is a date");
            }
            else
            {
                Console.WriteLine("Invalid Input");
                IsDate(GetUserInput("Enter a date  ( dd/mm/yyyy )"));
            }
        }
    }
}
