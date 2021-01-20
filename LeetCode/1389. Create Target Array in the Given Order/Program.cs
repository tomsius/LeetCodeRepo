using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1389.Create_Target_Array_in_the_Given_Order
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums1 = { 0, 1, 2, 3, 4 };
            int[] index1 = { 0, 1, 2, 2, 1 };
            Console.WriteLine(string.Join(", ", CreateTargetArray(nums1, index1)));

            int[] nums2 = { 1, 2, 3, 4, 0 };
            int[] index2 = { 0, 1, 2, 3, 0 };
            Console.WriteLine(string.Join(", ", CreateTargetArray(nums2, index2)));

            int[] nums3 = { 1 };
            int[] index3 = { 0 };
            Console.WriteLine(string.Join(", ", CreateTargetArray(nums3, index3)));

            Console.ReadKey();
        }

        public static int[] CreateTargetArray(int[] nums, int[] index)
        {
            List<int> output = new List<int>(nums.Length);

            for (int i = 0; i < nums.Length; i++)
            {
                output.Insert(index[i], nums[i]);
            }

            return output.ToArray();
        }
    }
}
