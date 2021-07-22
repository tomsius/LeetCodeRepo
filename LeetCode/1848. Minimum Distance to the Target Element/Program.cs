using System;

namespace _1848._Minimum_Distance_to_the_Target_Element
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums1 = { 1, 2, 3, 4, 5 };
            int target1 = 5;
            int start1 = 3;
            Console.WriteLine(GetMinDistance1(nums1, target1, start1));
            Console.WriteLine(GetMinDistance2(nums1, target1, start1));

            int[] nums2 = { 1 };
            int target2 = 1;
            int start2 = 0;
            Console.WriteLine(GetMinDistance1(nums2, target2, start2));
            Console.WriteLine(GetMinDistance2(nums2, target2, start2));

            int[] nums3 = { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 };
            int target3 = 1;
            int start3 = 0;
            Console.WriteLine(GetMinDistance1(nums3, target3, start3));
            Console.WriteLine(GetMinDistance2(nums3, target3, start3));
        }

        public static int GetMinDistance1(int[] nums, int target, int start)
        {
            int distance = 0;

            while (distance < nums.Length)
            {
                if (start + distance < nums.Length && (nums[start + distance] == target) 
                || (start - distance >= 0 && nums[start - distance] == target))
                {
                    return distance;
                }

                distance++;
            }

            return -1;
        }

        public static int GetMinDistance2(int[] nums, int target, int start)
        {
            int minDistance = int.MaxValue;

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == target)
                {
                    minDistance = Math.Min(minDistance, Math.Abs(start - i));
                }
            }

            return minDistance;
        }
    }
}
