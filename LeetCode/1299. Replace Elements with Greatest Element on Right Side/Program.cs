using System;

namespace _1299._Replace_Elements_with_Greatest_Element_on_Right_Side
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr1 = { 17, 18, 5, 4, 6, 1 };
            Console.WriteLine(string.Join(" ", ReplaceElements1(arr1)));
            arr1 = new int[]{ 17, 18, 5, 4, 6, 1 };
            Console.WriteLine(string.Join(" ", ReplaceElements2(arr1)));

            int[] arr2 = { 400 };
            Console.WriteLine(string.Join(" ", ReplaceElements1(arr2)));
            arr2 = new int[]{ 400 };
            Console.WriteLine(string.Join(" ", ReplaceElements2(arr2)));
        }

        public static int[] ReplaceElements1(int[] arr)
        {
            for (int i = 0; i < arr.Length - 1;)
            {
                int maxIndex = FindMaxIndexOnRightFrom(arr, i + 1);

                while (i < maxIndex)
                {
                    arr[i] = arr[maxIndex];
                    i++;
                }
            }

            arr[arr.Length - 1] = -1;

            return arr;
        }

        private static int FindMaxIndexOnRightFrom(int[] arr, int start)
        {
            int max = int.MinValue;
            int maxIndex = -1;

            for (int i = start; i < arr.Length; i++)
            {
                if (arr[i] > max)
                {
                    max = arr[i];
                    maxIndex = i;
                }
            }

            return maxIndex;
        }

        public static int[] ReplaceElements2(int[] arr)
        {
            int valueToReplaceWith = -1;
            int maxValue = int.MinValue;

            for (int i = arr.Length - 1; i >= 0; i--)
            {
                maxValue = Math.Max(maxValue, arr[i]);
                arr[i] = valueToReplaceWith;
                valueToReplaceWith = maxValue;
            }

            return arr;
        }
    }
}
