using System;

namespace _1534._Count_Good_Triplets
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr1 = { 3, 0, 1, 1, 9, 7 };
            int a1 = 7;
            int b1 = 2;
            int c1 = 3;
            Console.WriteLine(CountGoodTriplets(arr1, a1, b1, c1));

            int[] arr2 = { 1, 1, 2, 2, 3 };
            int a2 = 0;
            int b2 = 0;
            int c2 = 1;
            Console.WriteLine(CountGoodTriplets(arr2, a2, b2, c2));
        }

        public static int CountGoodTriplets(int[] arr, int a, int b, int c)
        {
            int goodTripletsCount = 0;

            for (int i = 0; i < arr.Length - 2; i++)
            {
                for (int j = i + 1; j < arr.Length - 1; j++)
                {
                    for (int k = j + 1; k < arr.Length; k++)
                    {
                        if (Math.Abs(arr[i] - arr[j]) <= a && Math.Abs(arr[j] - arr[k]) <= b && Math.Abs(arr[i] - arr[k]) <= c)
                        {
                            goodTripletsCount++;
                        }
                    }
                }
            }

            return goodTripletsCount;
        }
    }
}
