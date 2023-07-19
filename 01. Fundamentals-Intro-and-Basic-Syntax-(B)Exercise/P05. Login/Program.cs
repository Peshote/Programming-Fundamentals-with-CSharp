using System;

namespace P05._Login
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string username = Console.ReadLine();
            string password = string.Empty;
            string input = "";
            

            for (int i = username.Length - 1; i >=0; i--)
            {
                password += username[i];
            }
            
            input = Console.ReadLine();

            for (int i = 1; i <= 4; i++)
            {
                if (input != password)
                {                                        
                    if (i == 4)
                    {
                        Console.WriteLine($"User {username} blocked!");
                        break;
                    }

                    Console.WriteLine("Incorrect password. Try again.");

                }
                if (input == password)
                {
                    Console.WriteLine($"User {username} logged in.");
                    break;
                }
                input = Console.ReadLine();
            }
        }
    }
}