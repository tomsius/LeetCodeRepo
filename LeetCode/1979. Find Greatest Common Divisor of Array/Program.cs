using System;

namespace _1979._Find_Greatest_Common_Divisor_of_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums1 = { 2, 5, 6, 9, 10 };
            Console.WriteLine(FindGCD(nums1));

            int[] nums2 = { 7, 5, 6, 8, 3 };
            Console.WriteLine(FindGCD(nums2));

            int[] nums3 = { 3, 3 };
            Console.WriteLine(FindGCD(nums3));
        }

        public static int FindGCD(int[] nums)
        {
            int minimumValue = int.MaxValue;
            int maximumValue = int.MinValue;

            foreach (var num in nums)
            {
                minimumValue = Math.Min(minimumValue, num);
                maximumValue = Math.Max(maximumValue, num);
            }

            int gcd = minimumValue;

            while (maximumValue % gcd != 0 || minimumValue % gcd != 0)
            {
                gcd--;
            }

            return gcd;
        }
    }
}
