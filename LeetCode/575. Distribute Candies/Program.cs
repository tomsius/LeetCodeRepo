using System;
using System.Collections.Generic;

namespace _575._Distribute_Candies
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] candyType1 = { 1, 1, 2, 2, 3, 3 };
            Console.WriteLine(DistributeCandies1(candyType1));
            Console.WriteLine(DistributeCandies2(candyType1));
            Console.WriteLine(DistributeCandies3(candyType1));

            int[] candyType2 = { 1, 1, 2, 3 };
            Console.WriteLine(DistributeCandies1(candyType2));
            Console.WriteLine(DistributeCandies2(candyType2));
            Console.WriteLine(DistributeCandies3(candyType2));

            int[] candyType3 = { 6, 6, 6, 6 };
            Console.WriteLine(DistributeCandies1(candyType3));
            Console.WriteLine(DistributeCandies2(candyType3));
            Console.WriteLine(DistributeCandies3(candyType3));

            int[] candyType4 = { 100000, 0, 100000, 0, 100000, 0, 100000, 0, 100000, 0, 100000, 0 };
            Console.WriteLine(DistributeCandies1(candyType4));
            Console.WriteLine(DistributeCandies2(candyType4));
            Console.WriteLine(DistributeCandies3(candyType4));
        }

        public static int DistributeCandies1(int[] candyType)
        {
            HashSet<int> uniqueCandyTypes = new HashSet<int>();

            foreach (var candy in candyType)
            {
                uniqueCandyTypes.Add(candy);
            }

            if (uniqueCandyTypes.Count <= candyType.Length / 2)
            {
                return uniqueCandyTypes.Count;
            }
            else
            {
                return candyType.Length / 2;
            }
        }

        public static int DistributeCandies2(int[] candyType)
        {
            HashSet<int> uniqueCandyTypes = new HashSet<int>();

            foreach (var candy in candyType)
            {
                uniqueCandyTypes.Add(candy);
            }

            return Math.Min(uniqueCandyTypes.Count, candyType.Length / 2);
        }

        public static int DistributeCandies3(int[] candyType)
        {
            HashSet<int> uniqueCandyTypes = new HashSet<int>(candyType);

            return Math.Min(uniqueCandyTypes.Count, candyType.Length / 2);
        }
    }
}
