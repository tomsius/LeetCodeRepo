using System;

namespace _1437._Check_If_All_1_s_Are_at_Least_Length_K_Places_Away
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums1 = { 1, 0, 0, 0, 1, 0, 0, 1 };
            int k1 = 2;
            Console.WriteLine(KLengthApart(nums1, k1));

            int[] nums2 = { 1, 0, 0, 1, 0, 1 };
            int k2 = 2;
            Console.WriteLine(KLengthApart(nums2, k2));

            int[] nums3 = { 1, 1, 1, 1, 1 };
            int k3 = 0;
            Console.WriteLine(KLengthApart(nums3, k3));

            int[] nums4 = { 0, 1, 0, 1 };
            int k4 = 1;
            Console.WriteLine(KLengthApart(nums4, k4));
        }

        public static bool KLengthApart(int[] nums, int k)
        {
            int zeroCount = 0;
            int startIndex = 0;

            while (startIndex < nums.Length && nums[startIndex] != 1)
            {
                startIndex++;
            }

            for (int i = startIndex + 1; i < nums.Length; i++)
            {
                if (nums[i] == 0)
                {
                    zeroCount++;
                }
                else
                {
                    if (zeroCount < k)
                    {
                        return false;
                    }

                    zeroCount = 0;
                }
            }

            return true;
        }
    }
}
