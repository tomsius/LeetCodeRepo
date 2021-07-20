using System;

namespace _868._Binary_Gap
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1 = 22;
            Console.WriteLine(BinaryGap1(n1));
            Console.WriteLine(BinaryGap2(n1));

            int n2 = 5;
            Console.WriteLine(BinaryGap1(n2));
            Console.WriteLine(BinaryGap2(n2));

            int n3 = 6;
            Console.WriteLine(BinaryGap1(n3));
            Console.WriteLine(BinaryGap2(n3));

            int n4 = 8;
            Console.WriteLine(BinaryGap1(n4));
            Console.WriteLine(BinaryGap2(n4));

            int n5 = 1;
            Console.WriteLine(BinaryGap1(n5));
            Console.WriteLine(BinaryGap2(n5));
        }

        public static int BinaryGap1(int n)
        {
            string binaryRepresentation = Convert.ToString(n, 2);
            int longestDistance = 0;
            int index = binaryRepresentation.IndexOf('1') + 1;
            int currentDistance = 0;

            while (index < binaryRepresentation.Length)
            {
                currentDistance++;

                if (binaryRepresentation[index] == '1')
                {
                    longestDistance = Math.Max(longestDistance, currentDistance);
                    currentDistance = 0;
                }

                index++;
            }

            return longestDistance;
        }

        public static int BinaryGap2(int n)
        {
            int longestDistance = 0;
            int lastOnePosition = 0;
            int currentPosition = 0;

            while (n > 0)
            {
                currentPosition++;

                if (n % 2 == 1)
                {
                    if (lastOnePosition != 0)
                    {
                        longestDistance = Math.Max(longestDistance, currentPosition - lastOnePosition);
                    }

                    lastOnePosition = currentPosition;
                }

                n /= 2;
            }
            return longestDistance;
        }
    }
}
