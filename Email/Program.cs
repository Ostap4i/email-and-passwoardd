using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Email
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the email:");

            string email = Console.ReadLine();

        
            string pattern = @"^[a-zA-Z0-9._%+-]+@itstep\.ua$";

       
            bool isMatch = Regex.IsMatch(email, pattern);


            if (isMatch)
            {
                Console.WriteLine("The email address is valid with the itstep.ua domain.");
            }
            else
            {
                Console.WriteLine("The e-mail does not have the itstep.ua domain or the wrong format is entered");
            }
        }
    }
}

