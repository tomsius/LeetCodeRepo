using System;
using System.Collections.Generic;

namespace _1441._Build_an_Array_With_Stack_Operations
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] target1 = { 1, 3 };
            int n1 = 3;
            Console.WriteLine(String.Join(", ", BuildArray(target1, n1)));

            int[] target2 = { 1, 2, 3 };
            int n2 = 3;
            Console.WriteLine(String.Join(", ", BuildArray(target2, n2)));

            int[] target3 = { 1, 2 };
            int n3 = 4;
            Console.WriteLine(String.Join(", ", BuildArray(target3, n3)));

            int[] target4 = { 2, 3, 4 };
            int n4 = 4;
            Console.WriteLine(String.Join(", ", BuildArray(target4, n4)));
        }

        public static IList<string> BuildArray(int[] target, int n)
        {
            IList<string> operations = new List<string>();
            List<int> builtArray = new List<int>();
            int currentNumber = 1;

            while (builtArray.Count != target.Length)
            {
                builtArray.Add(currentNumber);
                currentNumber++;

                operations.Add("Push");

                if (builtArray[builtArray.Count - 1] != target[builtArray.Count - 1])
                {
                    operations.Add("Pop");
                    builtArray.RemoveAt(builtArray.Count - 1);
                }
            }

            return operations;
        }
    }
}
