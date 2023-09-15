using System;
using System.Collections.Generic;
using System.Linq;

namespace P05._Longest_Increasing_Subsequence
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            int n = nums.Length;

            int[] len = new int[n];
            int[] prev = new int[n];
            for (int i = 0; i < n; i++)
            {
                len[i] = 1;
                prev[i] = -1;
                for (int j = 0; j < i; j++)
                {
                    if (nums[j] < nums[i] && len[j] + 1 > len[i])
                    {
                        len[i] = len[j] + 1;
                        prev[i] = j;
                    }
                }
            }

            int maxLength = len.Max();
            int lastPos = Array.IndexOf(len, maxLength);

            List<int> lis = new List<int>();
            while (lastPos != -1)
            {
                lis.Add(nums[lastPos]);
                lastPos = prev[lastPos];
            }

            lis.Reverse();
            Console.WriteLine(string.Join(" ", lis));
        }
    }
}