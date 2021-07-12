using System;

namespace _1822._Sign_of_the_Product_of_an_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums1 = { -1, -2, -3, -4, 3, 2, 1 };
            Console.WriteLine(ArraySign(nums1));

            int[] nums2 = { 1, 5, 0, 2, -3 };
            Console.WriteLine(ArraySign(nums2));

            int[] nums3 = { -1, 1, -1, 1, -1 };
            Console.WriteLine(ArraySign(nums3));
        }

        public static int ArraySign(int[] nums)
        {
            int negativeNumbers = 0;

            foreach (var num in nums)
            {
                if (num == 0)
                {
                    return 0;
                }

                if (num < 0)
                {
                    negativeNumbers++;
                }
            }

            if (negativeNumbers % 2 == 0)
            {
                return 1;
            }
            else
            {
                return -1;
            }
        }
    }
}
