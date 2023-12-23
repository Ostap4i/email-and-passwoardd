using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _23._12._23
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string phoneNumber = "+380978660191"; // Замініть це значення на потрібний номер телефону

            if (IsUkrainianPhoneNumber(phoneNumber))
            {
                Console.WriteLine("This Ukrainian number.");
            }
            else
            {
                Console.WriteLine("This is'nt Ukrainian number.");
            }
        }

        static bool IsUkrainianPhoneNumber(string number)
        {
       
            string pattern = @"^\+380\d{9}$";

            return Regex.IsMatch(number, pattern);
        }
    }
}
