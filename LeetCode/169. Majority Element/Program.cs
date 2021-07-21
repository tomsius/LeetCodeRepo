using System;
using System.Collections.Generic;

namespace _169._Majority_Element
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums1 = { 3, 2, 3 };
            Console.WriteLine(MajorityElement1(nums1));
            nums1 = new int[]{ 3, 2, 3 };
            Console.WriteLine(MajorityElement2(nums1));
            Console.WriteLine(MajorityElement3(nums1));

            int[] nums2 = { 2, 2, 1, 1, 1, 2, 2 };
            Console.WriteLine(MajorityElement1(nums2));
            nums2 = new int[]{ 2, 2, 1, 1, 1, 2, 2 };
            Console.WriteLine(MajorityElement2(nums2));
            Console.WriteLine(MajorityElement3(nums2));
        }

        public static int MajorityElement1(int[] nums)
        {
            Array.Sort(nums);

            return nums[nums.Length / 2];
        }

        public static int MajorityElement2(int[] nums)
        {
            Dictionary<int, int> occurances = new Dictionary<int, int>();

            foreach (var num in nums)
            {
                if (occurances.ContainsKey(num))
                {
                    occurances[num]++;

                    if (occurances[num] > nums.Length / 2)
                    {
                        return num;
                    }
                }
                else
                {
                    occurances.Add(num, 1);
                }
            }

            return nums[0];
        }

        public static int MajorityElement3(int[] nums)
        {
            int count = 1;
            int candidate = nums[0];

            for (int i = 1; i < nums.Length; i++)
            {
                if (count == 0)
                {
                    candidate = nums[i];
                }

                if (nums[i] == candidate)
                {
                    count++;
                }
                else
                {
                    count--;
                }
            }

            return candidate;
        }
    }
}
