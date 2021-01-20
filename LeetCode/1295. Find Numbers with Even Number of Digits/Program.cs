using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1295.Find_Numbers_with_Even_Number_of_Digits
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums1 = { 12, 345, 2, 6, 7896 };
            Console.WriteLine(FindNumbers(nums1));

            int[] nums2 = { 555, 901, 482, 1771 };
            Console.WriteLine(FindNumbers(nums2));

            Console.ReadKey();
        }

        public static int FindNumbers(int[] nums)
        {
            int output = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i].ToString().Length % 2 == 0)
                {
                    output++;
                }
            }

            return output;
        }
    }
}
