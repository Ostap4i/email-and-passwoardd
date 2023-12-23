using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace passwoard
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Console.Write("Enter the passwoard: ");
                string password = Console.ReadLine();

                if (IsStrongPassword(password))
                {
                    Console.WriteLine("The password does meet the complexity requirements.");
                }
            else
            {
                    Console.WriteLine("The password does not meet the complexity requirements.");
                }
            }

            static bool IsStrongPassword(string password)
            {
                if (password.Length < 8)
                {
                    return false;
                }

                if (!password.Any(char.IsUpper))
                {
                    return false;
                }


                if (!password.Any(char.IsLower))
                {
                    return false;
                }

                if (!password.Any(char.IsDigit))
                {
                    return false;
                }

                string specialCharacters = "!@#$%";
                if (!password.Any(c => specialCharacters.Contains(c)))
                {
                    return false;
                }

                return true;
            }
        }
    }


