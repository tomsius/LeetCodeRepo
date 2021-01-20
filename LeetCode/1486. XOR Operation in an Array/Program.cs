using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1486.XOR_Operation_in_an_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1 = 5;
            int start1 = 0;
            Console.WriteLine(XorOperation(n1, start1));

            int n2 = 4;
            int start2 = 3;
            Console.WriteLine(XorOperation(n2, start2));

            int n3 = 1;
            int start3 = 7;
            Console.WriteLine(XorOperation(n3, start3));

            int n4 = 10;
            int start4 = 5;
            Console.WriteLine(XorOperation(n4, start4));

            Console.ReadKey();
        }

        public static int XorOperation(int n, int start)
        {
            int output = start;

            for (int i = 1; i < n; i++)
            {
                output ^= start + 2 * i;
            }

            return output;
        }
    }
}
