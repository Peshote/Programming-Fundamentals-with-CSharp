using System;
using System.Linq;

namespace P04._Password_Validator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string password = Console.ReadLine();

            bool isValid = IsPasswordValid(password);

            if (isValid)
            {
                Console.WriteLine("Password is valid");
            }
        }

        public static bool IsPasswordValid(string password)
        {
            bool isValid = true;

            if (!IsPasswordLengthValid(password))
            {
                Console.WriteLine("Password must be between 6 and 10 characters");
                isValid = false;
            }

            if (!IsPasswordConsistOfLettersAndDigits(password))
            {
                Console.WriteLine("Password must consist only of letters and digits");
                isValid = false;
            }

            if (!HasAtLeastTwoDigits(password))
            {
                Console.WriteLine("Password must have at least 2 digits");
                isValid = false;
            }

            return isValid;
        }

        public static bool IsPasswordLengthValid(string password)
        {
            int passwordLength = password.Length;
            return passwordLength >= 6 && passwordLength <= 10;
        }

        public static bool IsPasswordConsistOfLettersAndDigits(string password)
        {
            return password.All(char.IsLetterOrDigit);
        }

        public static bool HasAtLeastTwoDigits(string password)
        {
            int digitCount = password.Count(char.IsDigit);
            return digitCount >= 2;
        }
    }
}