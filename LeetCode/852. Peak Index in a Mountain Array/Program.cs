using System;

namespace _852._Peak_Index_in_a_Mountain_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr1 = { 0, 1, 0 };
            Console.WriteLine(PeakIndexInMountainArray1(arr1));
            Console.WriteLine(PeakIndexInMountainArray2(arr1));

            int[] arr2 = { 0, 2, 1, 0 };
            Console.WriteLine(PeakIndexInMountainArray1(arr2));
            Console.WriteLine(PeakIndexInMountainArray2(arr2));

            int[] arr3 = { 0, 10, 5, 2 };
            Console.WriteLine(PeakIndexInMountainArray1(arr3));
            Console.WriteLine(PeakIndexInMountainArray2(arr3));

            int[] arr4 = { 3, 4, 5, 1 };
            Console.WriteLine(PeakIndexInMountainArray1(arr4));
            Console.WriteLine(PeakIndexInMountainArray2(arr4));

            int[] arr5 = { 24, 69, 100, 99, 79, 78, 67, 36, 26, 19 };
            Console.WriteLine(PeakIndexInMountainArray1(arr5));
            Console.WriteLine(PeakIndexInMountainArray2(arr5));

            int[] arr6 = { 18, 29, 38, 59, 98, 100, 99, 98, 90 };
            Console.WriteLine(PeakIndexInMountainArray1(arr6));
            Console.WriteLine(PeakIndexInMountainArray2(arr6));
        }

        public static int PeakIndexInMountainArray1(int[] arr)
        {
            for (int i = 0; i < arr.Length - 1; i++)
            {
                if (arr[i] > arr[i + 1])
                {
                    return i;
                }
            }

            return arr.Length - 1;
        }

        public static int PeakIndexInMountainArray2(int[] arr)
        {
            int left = 0;
            int right = arr.Length - 1;
            int middle = -1;

            while (left <= right)
            {
                middle = (left + right) / 2;

                if (arr[middle] > arr[middle - 1] && arr[middle] > arr[middle + 1])
                {
                    break;
                }
                else if (arr[middle] > arr[middle - 1] && arr[middle] < arr[middle + 1])
                {
                    left = middle;
                }
                else
                {
                    right = middle;
                }
            }

            return middle;
        }
    }
}
