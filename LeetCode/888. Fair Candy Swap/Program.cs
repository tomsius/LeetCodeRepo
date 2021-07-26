using System;
using System.Collections.Generic;
using System.Linq;

namespace _888._Fair_Candy_Swap
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] aliceSizes1 = { 1, 1 };
            int[] bobSizes1 = { 2, 2 };
            Console.WriteLine(String.Join(", ", FairCandySwap1(aliceSizes1, bobSizes1)));
            Console.WriteLine(String.Join(", ", FairCandySwap2(aliceSizes1, bobSizes1)));

            int[] aliceSizes2 = { 1, 2 };
            int[] bobSizes2 = { 2, 3 };
            Console.WriteLine(String.Join(", ", FairCandySwap1(aliceSizes2, bobSizes2)));
            Console.WriteLine(String.Join(", ", FairCandySwap2(aliceSizes2, bobSizes2)));

            int[] aliceSizes3 = { 2 };
            int[] bobSizes3 = { 1, 3 };
            Console.WriteLine(String.Join(", ", FairCandySwap1(aliceSizes3, bobSizes3)));
            Console.WriteLine(String.Join(", ", FairCandySwap2(aliceSizes3, bobSizes3)));

            int[] aliceSizes4 = { 1, 2, 5 };
            int[] bobSizes4 = { 2, 4 };
            Console.WriteLine(String.Join(", ", FairCandySwap1(aliceSizes4, bobSizes4)));
            Console.WriteLine(String.Join(", ", FairCandySwap2(aliceSizes4, bobSizes4)));
        }

        public static int[] FairCandySwap1(int[] aliceSizes, int[] bobSizes)
        {
            int aliceCandiesSum = aliceSizes.Sum();
            int bobCandiesSum = bobSizes.Sum();

            for (int i = 0; i < aliceSizes.Length; i++)
            {
                for (int j = 0; j < bobSizes.Length; j++)
                {
                    if (aliceCandiesSum - aliceSizes[i] + bobSizes[j] == bobCandiesSum - bobSizes[j] + aliceSizes[i])
                    {
                        return new int[] { aliceSizes[i], bobSizes[j] };
                    }
                }
            }

            return new int[] { };
        }

        public static int[] FairCandySwap2(int[] aliceSizes, int[] bobSizes)
        {
            int aliceCandiesSum = aliceSizes.Sum();
            int bobCandiesSum = bobSizes.Sum();
            int delta = (bobCandiesSum - aliceCandiesSum) / 2;
            HashSet<int> bobCandies = new HashSet<int>(bobSizes);

            foreach (var aliceCandie in aliceSizes)
            {
                if (bobCandies.Contains(aliceCandie + delta))
                {
                    return new int[] { aliceCandie, aliceCandie + delta };
                }
            }

            return new int[] { };
        }
    }
}
