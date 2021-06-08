using System;

namespace _977._Squares_of_a_Sorted_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums1 = { -4, -1, 0, 3, 10 };
            Console.WriteLine(String.Join(", ", SortedSquares1(nums1)));
            Console.WriteLine(String.Join(", ", SortedSquares2(nums1)));

            int[] nums2 = { -7, -3, 2, 3, 11 };
            Console.WriteLine(String.Join(", ", SortedSquares1(nums2)));
            Console.WriteLine(String.Join(", ", SortedSquares2(nums2)));

            int[] nums3 = { -5, -3, -2, -1 };
            Console.WriteLine(String.Join(", ", SortedSquares1(nums3)));
            Console.WriteLine(String.Join(", ", SortedSquares2(nums3)));
        }

        public static int[] SortedSquares1(int[] nums)
        {
            int smallestAbsoluteValueIndex = FindSmallestValueIndex(nums);
            int[] squaredValues = new int[nums.Length];
            int index = 0;
            int leftIndex = smallestAbsoluteValueIndex - 1;
            int rightIndex = smallestAbsoluteValueIndex + 1;

            while (index < nums.Length)
            {
                squaredValues[index++] = (int)Math.Pow(nums[smallestAbsoluteValueIndex], 2);

                if (leftIndex < 0)
                {
                    smallestAbsoluteValueIndex = rightIndex;
                    rightIndex++;
                    continue;
                }

                if (rightIndex >= nums.Length)
                {
                    smallestAbsoluteValueIndex = leftIndex;
                    leftIndex--;
                    continue;
                }

                if (Math.Abs(nums[leftIndex]) < Math.Abs(nums[rightIndex]))
                {
                    smallestAbsoluteValueIndex = leftIndex;
                    leftIndex--;
                }
                else
                {
                    smallestAbsoluteValueIndex = rightIndex;
                    rightIndex++;
                }
            }

            return squaredValues;
        }

        private static int FindSmallestValueIndex(int[] nums)
        {
            int smallestIndex = 0;

            for (int i = 1; i < nums.Length; i++)
            {
                if (Math.Abs(nums[i]) < Math.Abs(nums[smallestIndex]))
                {
                    smallestIndex = i;
                }
            }

            return smallestIndex;
        }

        public static int[] SortedSquares2(int[] nums)
        {
            int[] squaredValues = new int[nums.Length];
            int low = 0;
            int high = nums.Length - 1;
            int index = nums.Length - 1;

            while (low <= high)
            {
                if (Math.Abs(nums[low]) > Math.Abs(nums[high]))
                {
                    squaredValues[index--] = (int)Math.Pow(nums[low], 2);
                    low++;
                }
                else
                {
                    squaredValues[index--] = (int)Math.Pow(nums[high], 2);
                    high--;

                }
            }
            return squaredValues;
        }
    }
}
