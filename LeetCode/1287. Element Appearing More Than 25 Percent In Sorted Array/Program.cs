using System;

namespace _1287._Element_Appearing_More_Than_25_Percent_In_Sorted_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr1 = { 1, 2, 2, 6, 6, 6, 6, 7, 10 };
            Console.WriteLine(FindSpecialInteger1(arr1));
            Console.WriteLine(FindSpecialInteger2(arr1));
            Console.WriteLine(FindSpecialInteger3(arr1));

            int[] arr2 = { 1, 1 };
            Console.WriteLine(FindSpecialInteger1(arr2));
            Console.WriteLine(FindSpecialInteger2(arr2));
            Console.WriteLine(FindSpecialInteger3(arr2));

            int[] arr3 = { 1 };
            Console.WriteLine(FindSpecialInteger1(arr3));
            Console.WriteLine(FindSpecialInteger2(arr3));
            Console.WriteLine(FindSpecialInteger3(arr3));
        }

        public static int FindSpecialInteger1(int[] arr)
        {
            if (arr.Length == 1)
            {
                return arr[0];
            }

            for (int i = 1; i < arr.Length; i++)
            {
                int counter = 1;

                while (i < arr.Length && arr[i - 1] == arr[i])
                {
                    counter++;
                    i++;
                }

                if (counter > arr.Length / 4)
                {
                    return arr[i - 1];
                }
            }

            return -1;
        }

        public static int FindSpecialInteger2(int[] arr)
        {
            int startIndex = arr.Length / 4;

            for (int i = startIndex; i < arr.Length; i++)
            {
                if (arr[i] == arr[i - startIndex])
                {
                    return arr[i];
                }
            }

            return -1;
        }

        public static int FindSpecialInteger3(int[] arr)
        {
            int step = arr.Length / 4;
            int i = 0;

            while (i < arr.Length - step && arr[i] != arr[i + step])
            {
                i++;
            }

            return arr[i];
        }
    }
}
