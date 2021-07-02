using System;
using System.Collections.Generic;
using System.Linq;

namespace _1636._Sort_Array_by_Increasing_Frequency
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums1 = { 1, 1, 2, 2, 2, 3 };
            Console.WriteLine(String.Join(", ", FrequencySort1(nums1)));
            Console.WriteLine(String.Join(", ", FrequencySort2(nums1)));

            int[] nums2 = { 2, 3, 1, 3, 2 };
            Console.WriteLine(String.Join(", ", FrequencySort1(nums2)));
            Console.WriteLine(String.Join(", ", FrequencySort2(nums2)));

            int[] nums3 = { -1, 1, -6, 4, 5, -6, 1, 4, 1 };
            Console.WriteLine(String.Join(", ", FrequencySort1(nums3)));
            Console.WriteLine(String.Join(", ", FrequencySort2(nums3)));
        }

        public static int[] FrequencySort1(int[] nums)
        {
            Dictionary<int, List<int>> frequencies = new Dictionary<int, List<int>>();

            foreach (var num in nums)
            {
                if (frequencies.ContainsKey(num))
                {
                    frequencies[num].Add(num);
                }
                else
                {
                    frequencies.Add(num, new List<int> { num });
                }
            }

            var sortedFrequencies = frequencies.ToList();
            sortedFrequencies.Sort((x, y) => 
                {
                    int cmp = x.Value.Count.CompareTo(y.Value.Count);

                    if (cmp != 0)
                    {
                        return cmp;
                    }

                    return y.Key.CompareTo(x.Key);
                });

            List<int> sortedNums = new List<int>(nums.Length);

            foreach (var pair in sortedFrequencies)
            {
                sortedNums.AddRange(pair.Value);
            }

            return sortedNums.ToArray();
        }

        public static int[] FrequencySort2(int[] nums)
        {
            Dictionary<int, int> frequencies = new Dictionary<int, int>();

            foreach (var num in nums)
            {
                if (frequencies.ContainsKey(num))
                {
                    frequencies[num]++;
                }
                else
                {
                    frequencies.Add(num, 1);
                }
            }

            var sortedFrequencies = frequencies.OrderBy(x => x.Value).ThenByDescending(x => x.Key);

            int[] sortedNums = new int[nums.Length];
            int index = 0;

            foreach (var pair in sortedFrequencies)
            {
                for (int i = 0; i < pair.Value; i++)
                {
                    sortedNums[index++] = pair.Key;
                }
            }

            return sortedNums;
        }
    }
}
