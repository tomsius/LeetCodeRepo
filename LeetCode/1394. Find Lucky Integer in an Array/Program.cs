using System;

namespace _1394._Find_Lucky_Integer_in_an_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr1 = { 2, 2, 3, 4 };
            Console.WriteLine(FindLucky(arr1));

            int[] arr2 = { 1, 2, 2, 3, 3, 3 };
            Console.WriteLine(FindLucky(arr2));

            int[] arr3 = { 2, 2, 2, 3, 3 };
            Console.WriteLine(FindLucky(arr3));

            int[] arr4 = { 5 };
            Console.WriteLine(FindLucky(arr4));

            int[] arr5 = { 7, 7, 7, 7, 7, 7, 7 };
            Console.WriteLine(FindLucky(arr5));
        }

        public static int FindLucky(int[] arr)
        {
            Array.Sort(arr);

            for (int i = arr.Length - 1; i >= 0; i--)
            {
                int numberFrequency = 1;
                int number = arr[i];

                while (i >= 1 && arr[i] == arr[i - 1])
                {
                    numberFrequency++;
                    i--;
                }

                if (numberFrequency == number)
                {
                    return number;
                }
            }

            return -1;
        }
    }
}
