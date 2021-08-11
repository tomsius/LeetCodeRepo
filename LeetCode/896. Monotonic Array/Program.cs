using System;

namespace _896._Monotonic_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums1 = { 1, 2, 2, 3 };
            Console.WriteLine(IsMonotonic1(nums1));
            Console.WriteLine(IsMonotonic2(nums1));
            Console.WriteLine(IsMonotonic3(nums1));

            int[] nums2 = { 6, 5, 4, 4 };
            Console.WriteLine(IsMonotonic1(nums2));
            Console.WriteLine(IsMonotonic2(nums2));
            Console.WriteLine(IsMonotonic3(nums2));

            int[] nums3 = { 1, 3, 2 };
            Console.WriteLine(IsMonotonic1(nums3));
            Console.WriteLine(IsMonotonic2(nums3));
            Console.WriteLine(IsMonotonic3(nums3));

            int[] nums4 = { 1, 2, 4, 5 };
            Console.WriteLine(IsMonotonic1(nums4));
            Console.WriteLine(IsMonotonic2(nums4));
            Console.WriteLine(IsMonotonic3(nums4));

            int[] nums5 = { 1, 1, 1 };
            Console.WriteLine(IsMonotonic1(nums5));
            Console.WriteLine(IsMonotonic2(nums5));
            Console.WriteLine(IsMonotonic3(nums5));
        }

        public static bool IsMonotonic1(int[] nums)
        {
            return IsMonotoneIncreasing(nums) || IsMonotoneDecreasing(nums);
        }

        private static bool IsMonotoneIncreasing(int[] nums)
        {
            for (int i = 0; i < nums.Length - 1; i++)
            {
                if (nums[i] > nums[i + 1])
                {
                    return false;
                }
            }

            return true;
        }

        private static bool IsMonotoneDecreasing(int[] nums)
        {
            for (int i = 0; i < nums.Length - 1; i++)
            {
                if (nums[i] < nums[i + 1])
                {
                    return false;
                }
            }

            return true;
        }

        public static bool IsMonotonic2(int[] nums)
        {
            int isIncreasing = 0;

            for (int i = 0; i < nums.Length - 1; i++)
            {
                int compareResult = nums[i].CompareTo(nums[i + 1]);

                if (compareResult != 0)
                {
                    if (compareResult != isIncreasing && isIncreasing != 0)
                    {
                        return false;
                    }

                    isIncreasing = compareResult;
                }
            }

            return true;
        }

        public static bool IsMonotonic3(int[] nums)
        {
            bool isIncreasing = true;
            bool isDecreasing = true;

            for (int i = 0; i < nums.Length - 1; i++)
            {
                if (nums[i] > nums[i + 1])
                {
                    isIncreasing = false;
                }

                if (nums[i] < nums[i + 1])
                {
                    isDecreasing = false;
                }
            }

            return isIncreasing || isDecreasing;
        }
    }
}
