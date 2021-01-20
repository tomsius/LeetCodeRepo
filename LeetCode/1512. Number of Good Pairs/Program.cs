using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1512.Number_of_Good_Pairs
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums1 = { 1, 2, 3, 1, 1, 3 };
            Console.WriteLine(NumIdenticalPairs(nums1));
            Console.WriteLine(NumIdenticalPairs2(nums1));
            Console.WriteLine(NumIdenticalPairs3(nums1));

            int[] nums2 = { 1, 1, 1, 1 };
            Console.WriteLine(NumIdenticalPairs(nums2));
            Console.WriteLine(NumIdenticalPairs2(nums2));
            Console.WriteLine(NumIdenticalPairs3(nums2));

            int[] nums3 = { 1, 2, 3 };
            Console.WriteLine(NumIdenticalPairs(nums3));
            Console.WriteLine(NumIdenticalPairs2(nums3));
            Console.WriteLine(NumIdenticalPairs3(nums3));

            Console.ReadKey();
        }

        public static int NumIdenticalPairs(int[] nums)
        {
            int countOfGoodPairs = 0;

            for (int i = 0; i < nums.Length - 1; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (nums[i] == nums[j])
                    {
                        countOfGoodPairs++;
                    }
                }
            }

            return countOfGoodPairs;
        }

        public static int NumIdenticalPairs2(int[] nums)
        {
            int countOfGoodPairs = 0;
            Dictionary<int, int> dictionary = new Dictionary<int, int>(nums.Length + 1);

            for (int i = 0; i < nums.Length; i++)
            {
                if (dictionary.ContainsKey(nums[i]))
                {
                    dictionary[nums[i]] += 1;
                }
                else
                {
                    dictionary.Add(nums[i], 1);
                }
            }

            foreach (KeyValuePair<int, int> kv in dictionary)
            {
                if (kv.Value != 1)
                {
                    countOfGoodPairs += kv.Value * (kv.Value - 1) / 2;
                }
            }

            return countOfGoodPairs;
        }

        public static int NumIdenticalPairs3(int[] nums)
        {
            int countOfGoodPairs = 0;
            int[] occurances = new int[101];

            for (int i = 0; i < nums.Length; i++)
            {
                occurances[nums[i]]++;
            }

            for (int i = 0; i < occurances.Length; i++)
            {
                if (occurances[i] > 1)
                {
                    countOfGoodPairs += occurances[i] * (occurances[i] - 1) / 2;
                }
            }

            return countOfGoodPairs;
        }
    }
}
