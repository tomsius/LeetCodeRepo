using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1672.Richest_Customer_Wealth
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][] accounts = { new int[] { 1, 2, 3 }, 
                                 new int[] { 3, 2, 1 } };
            Console.WriteLine(MaximumWealth(accounts));

            int[][] accounts2 = { new int[] { 1, 5 }, 
                                  new int[] { 7, 3 }, 
                                  new int[] { 3, 5 } };
            Console.WriteLine(MaximumWealth(accounts2));

            int[][] accounts3 = { new int[] { 2, 8, 7 }, 
                                  new int[] { 7, 1, 3 }, 
                                  new int[] { 1, 9, 5 } };
            Console.WriteLine(MaximumWealth(accounts3));

            Console.ReadKey();
        }

        public static int MaximumWealth(int[][] accounts)
        {
            int maxSum = 0;

            for (int i = 0; i < accounts.Length; i++)
            {
                maxSum = Math.Max(maxSum, Findsum(accounts[i]));
            }

            return maxSum;
        }

        private static int Findsum(int[] banks)
        {
            int sum = 0;

            for (int i = 0; i < banks.Length; i++)
            {
                sum += banks[i];
            }

            return sum;
        }
    }
}
