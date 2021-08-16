using System;
using System.Linq;

namespace _167._Two_Sum_II___Input_array_is_sorted
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers1 = { 2, 7, 11, 15 };
            int target1 = 9;
            Console.WriteLine(String.Join(", ", TwoSum(numbers1, target1)));

            int[] numbers2 = { 2, 3, 4 };
            int target2 = 6;
            Console.WriteLine(String.Join(", ", TwoSum(numbers2, target2)));

            int[] numbers3 = { -1, 0 };
            int target3 = -1;
            Console.WriteLine(String.Join(", ", TwoSum(numbers3, target3)));
        }

        public static int[] TwoSum(int[] numbers, int target)
        {
            int[] indices = new int[2];

            for (int i = 0; i < numbers.Length - 1; i++)
            {
                int startIndex = i + 1;
                int difference = target - numbers[i];
                int differenceAtIndex = BinarySearch(numbers, startIndex, difference);

                if (differenceAtIndex != -1)
                {
                    indices[0] = startIndex;
                    indices[1] = differenceAtIndex + 1;

                    break;
                }
            }

            return indices;
        }

        private static int BinarySearch(int[] numbers, int left, int difference)
        {
            int right = numbers.Length - 1;

            while (left <= right)
            {
                int middle = left + (right - left) / 2;

                if (numbers[middle] == difference)
                {
                    return middle;
                }
                else if (numbers[middle] < difference)
                {
                    left = middle + 1;
                }
                else
                {
                    right = middle - 1;
                }
            }

            return -1;
        }
    }
}
