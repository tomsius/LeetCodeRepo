using System;

namespace _1869._Longer_Contiguous_Segments_of_Ones_than_Zeros
{
    class Program
    {
        static void Main(string[] args)
        {
            string s1 = "1101";
            Console.WriteLine(CheckZeroOnes1(s1));

            string s2 = "111000";
            Console.WriteLine(CheckZeroOnes1(s2));

            string s3 = "110100010";
            Console.WriteLine(CheckZeroOnes1(s3));
        }

        public static bool CheckZeroOnes1(string s)
        {
            int contiguousOnesCount = GetContiguousCountFor(s, '1');
            int contiguousZerosCount = GetContiguousCountFor(s, '0');

            return contiguousOnesCount > contiguousZerosCount;
        }

        private static int GetContiguousCountFor(string s, char digit)
        {
            int maximumSequenceLength = 0;
            int currentSequenceLength = 0;

            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == digit)
                {
                    currentSequenceLength++;
                }
                else
                {
                    maximumSequenceLength = Math.Max(maximumSequenceLength, currentSequenceLength);
                    currentSequenceLength = 0;
                }
            }

            maximumSequenceLength = Math.Max(maximumSequenceLength, currentSequenceLength);

            return maximumSequenceLength;
        }
    }
}
