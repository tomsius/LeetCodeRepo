using System;
using System.Collections.Generic;

namespace _217._Contains_Duplicate
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums1 = { 1, 2, 3, 1 };
            Console.WriteLine(ContainsDuplicate1(nums1));
            Console.WriteLine(ContainsDuplicate2(nums1));

            int[] nums2 = { 1, 2, 3, 4 };
            Console.WriteLine(ContainsDuplicate1(nums2));
            Console.WriteLine(ContainsDuplicate2(nums2));

            int[] nums3 = { 1, 1, 1, 3, 3, 4, 3, 2, 4, 2 };
            Console.WriteLine(ContainsDuplicate1(nums3));
            Console.WriteLine(ContainsDuplicate2(nums3));
        }

        public static bool ContainsDuplicate1(int[] nums)
        {
            HashSet<int> uniqueNumbers = new HashSet<int>(nums.Length);

            foreach (var num in nums)
            {
                if (!uniqueNumbers.Add(num))
                {
                    return true;
                }
            }

            return false;
        }

        public static bool ContainsDuplicate2(int[] nums)
        {
            Array.Sort(nums);

            for (int i = 0; i < nums.Length - 1; i++)
            {
                if (nums[i] == nums[i + 1])
                {
                    return true;
                }
            }

            return false;
        }
    }
}
