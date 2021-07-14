using System;

namespace _1550._Three_Consecutive_Odds
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr1 = { 2, 6, 4, 1 };
            Console.WriteLine(ThreeConsecutiveOdds1(arr1));
            Console.WriteLine(ThreeConsecutiveOdds2(arr1));

            int[] arr2 = { 1, 2, 34, 3, 4, 5, 7, 23, 12 };
            Console.WriteLine(ThreeConsecutiveOdds1(arr2));
            Console.WriteLine(ThreeConsecutiveOdds2(arr2));
        }

        public static bool ThreeConsecutiveOdds1(int[] arr)
        {
            for (int i = 0; i < arr.Length - 2; i++)
            {
                if (arr[i] % 2 == 1 && arr[ i + 1] % 2 == 1 && arr[i + 2] % 2 == 1)
                {
                    return true;
                }
            }

            return false;
        }

        public static bool ThreeConsecutiveOdds2(int[] arr)
        {
            int oddsInARow = 0;

            foreach (var num in arr)
            {
                if (num % 2 == 1)
                {
                    oddsInARow++;
                }
                else
                {
                    oddsInARow = 0;
                }

                if (oddsInARow == 3)
                {
                    return true;
                }
            }

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 == 1)
                {
                    oddsInARow++;
                }
                else
                {
                    oddsInARow = 0;
                }

                if (oddsInARow == 3)
                {
                    return true;
                }
            }

            return false;
        }
    }
}
