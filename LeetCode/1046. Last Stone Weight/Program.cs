using System;

namespace _1046._Last_Stone_Weight
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] stones1 = { 2, 7, 4, 1, 8, 1 };
            Console.WriteLine(LastStoneWeight(stones1));

            int[] stones2 = { 2, 7, 4, 1, 8 };
            Console.WriteLine(LastStoneWeight(stones2));

            int[] stones3 = { 1 };
            Console.WriteLine(LastStoneWeight(stones3));
        }

        public static int LastStoneWeight(int[] stones)
        {
            Array.Sort(stones);

            while (stones.Length > 1 && stones[^2] != 0)
            {
                if (stones[^1] == stones[^2])
                {
                    stones[^1] = 0;
                }
                else
                {
                    stones[^1] -= stones[^2];
                }

                stones[^2] = 0;

                Array.Sort(stones);
            }

            return stones[^1];
        }
    }
}
