using System;

namespace _1385._Find_the_Distance_Value_Between_Two_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr11 = { 4, 5, 8 };
            int[] arr21 = { 10, 9, 1, 8 };
            int d1 = 2;
            Console.WriteLine(FindTheDistanceValue1(arr11, arr21, d1));
            Console.WriteLine(FindTheDistanceValue2(arr11, arr21, d1));

            int[] arr12 = { 1, 4, 2, 3 };
            int[] arr22 = { -4, -3, 6, 10, 20, 30 };
            int d2 = 3;
            Console.WriteLine(FindTheDistanceValue1(arr12, arr22, d2));
            Console.WriteLine(FindTheDistanceValue2(arr12, arr22, d2));

            int[] arr13 = { 2, 1, 100, 3 };
            int[] arr23 = { -5, -2, 10, -3, 7 };
            int d3 = 6;
            Console.WriteLine(FindTheDistanceValue1(arr13, arr23, d3));
            Console.WriteLine(FindTheDistanceValue2(arr13, arr23, d3));
        }

        public static int FindTheDistanceValue1(int[] arr1, int[] arr2, int d)
        {
            int distanceValue = 0;

            foreach (var value in arr1)
            {
                if (IsValueDistanced(value, arr2, d))
                {
                    distanceValue++;
                }
            }

            return distanceValue;
        }

        private static bool IsValueDistanced(int value1, int[] arr, int d)
        {
            foreach (var value2 in arr)
            {
                if (Math.Abs(value1 - value2) <= d)
                {
                    return false;
                }
            }

            return true;
        }

        public static int FindTheDistanceValue2(int[] arr1, int[] arr2, int d)
        {
            int distanceValue = 0;
            Array.Sort(arr2);

            foreach (var value in arr1)
            {
                int index = ClosestBinarySearch(arr2, value);
                if (Math.Abs(value - arr2[index]) > d)
                {
                    distanceValue++;
                }
            }

            return distanceValue;
        }

        private static int ClosestBinarySearch(int[] arr, int value)
        {
            int start = 0;
            int end = arr.Length - 1;

            while (start <= end)
            {
                int mid = start + (end - start) / 2;

                if (arr[mid] > value)
                {
                    end = mid - 1;
                }
                else if (arr[mid] < value)
                {
                    start = mid + 1;
                }
                else
                {
                    return mid;
                }
            }

            if (end < 0)
            {
                return start;
            }

            if (start == arr.Length)
            {
                return end;
            }

            return Math.Abs(arr[start] - value) < Math.Abs(arr[end] - value) ? start : end;
        }
    }
}
