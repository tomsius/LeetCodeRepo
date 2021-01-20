using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1431.Kids_With_the_Greatest_Number_of_Candies
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] candies1 = { 2, 3, 5, 1, 3 };
            int extraCandies1 = 3;
            Console.WriteLine(string.Join(" ", KidsWithCandies(candies1, extraCandies1)));

            int[] candies2 = { 4, 2, 1, 1, 2 };
            int extraCandies2 = 1;
            Console.WriteLine(string.Join(" ", KidsWithCandies(candies2, extraCandies2)));

            int[] candies3 = { 12, 1, 12 };
            int extraCandies3 = 10;
            Console.WriteLine(string.Join(" ", KidsWithCandies(candies3, extraCandies3)));

            Console.ReadKey();
        }

        public static IList<bool> KidsWithCandies(int[] candies, int extraCandies)
        {
            IList<bool> output = new List<bool>();
            int maxCandies = FindMaxCandies(candies);

            for (int i = 0; i < candies.Length; i++)
            {
                if (candies[i] + extraCandies >= maxCandies)
                {
                    output.Add(true);
                }
                else
                {
                    output.Add(false);
                }
            }

            return output;
        }

        private static int FindMaxCandies(int[] candies)
        {
            int maxCandies = 0;

            for (int i = 0; i < candies.Length; i++)
            {
                maxCandies = Math.Max(maxCandies, candies[i]);
            }

            return maxCandies;
        }
    }
}
