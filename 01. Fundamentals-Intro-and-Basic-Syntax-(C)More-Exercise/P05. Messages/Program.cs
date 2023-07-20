using System;
using System.Net.NetworkInformation;

namespace P05._Messages
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int inputCount = int.Parse(Console.ReadLine());
            string sms = "";
            
            for (int i = 0; i < inputCount; i++)
            {
                string number = Console.ReadLine();

                int mainDigit = number[0] - '0';
                
                if (mainDigit == 0)
                {
                    sms += " ";
                    continue;
                }
                int offset = (mainDigit - 2) * 3;

                if (mainDigit == 8 || mainDigit == 9)
                {
                    offset += 1;
                }

                int digitLength = number.Length;
                int letterIndex = (offset + digitLength -1);
               
                char letter = (char)(97 + letterIndex);

                sms += letter;
            }
            Console.WriteLine(sms);
        }
    }
}
