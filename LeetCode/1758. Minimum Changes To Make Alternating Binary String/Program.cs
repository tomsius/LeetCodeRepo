using System;

namespace _1758._Minimum_Changes_To_Make_Alternating_Binary_String
{
    class Program
    {
        static void Main(string[] args)
        {
            string s1 = "0100";
            Console.WriteLine(MinOperations(s1));

            string s2 = "10";
            Console.WriteLine(MinOperations(s2));

            string s3 = "1111";
            Console.WriteLine(MinOperations(s3));

            string s4 = "10010100";
            Console.WriteLine(MinOperations(s4));
        }

        public static int MinOperations(string s)
        {
            int operationsToStartWithZero = OperationsCount(s, '0');
            int operationsToStartWithOne = OperationsCount(s, '1');

            return Math.Min(operationsToStartWithZero, operationsToStartWithOne);
        }

        private static int OperationsCount(string s, char expectedBinary)
        {
            int operationsNeeded = 0;

            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] != expectedBinary)
                {
                    operationsNeeded++;
                    expectedBinary = s[i] == '0' ? '0' : '1';
                }
                else
                {
                    expectedBinary = s[i] == '0' ? '1' : '0';
                }
            }

            return operationsNeeded;
        }
    }
}
