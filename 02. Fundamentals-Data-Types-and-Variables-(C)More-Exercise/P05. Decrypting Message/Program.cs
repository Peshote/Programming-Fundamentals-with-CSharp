using System;

namespace P05._Decrypting_Message
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int key = int.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());
            string decryptedMessage = String.Empty;
            int symbolSum = 0;
 
            for (int i = 0; i < n; i++)
            {
                char symbol = char.Parse(Console.ReadLine());
 
                symbolSum = (int)symbol + key;
                decryptedMessage += (char)symbolSum;
 
            }
            Console.Write(decryptedMessage);
        }
    }
}