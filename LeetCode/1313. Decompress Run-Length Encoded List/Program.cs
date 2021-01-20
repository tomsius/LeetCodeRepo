using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1313.Decompress_Run_Length_Encoded_List
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums1 = { 1, 2, 3, 4 };
            Console.WriteLine(string.Join(" ", DecompressRLElist(nums1)));

            int[] nums2 = { 1, 1, 2, 3 };
            Console.WriteLine(string.Join(" ", DecompressRLElist(nums2)));

            Console.ReadKey();
        }

        public static int[] DecompressRLElist(int[] nums)
        {
            List<int> decompressed = new List<int>();

            for (int i = 0; i < nums.Length; i += 2)
            {
                for (int j = 0; j < nums[i]; j++)
                {
                    decompressed.Add(nums[i + 1]);
                }
            }
            
            return decompressed.ToArray();
        }
    }
}
