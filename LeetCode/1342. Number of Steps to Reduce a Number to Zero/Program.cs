using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1342.Number_of_Steps_to_Reduce_a_Number_to_Zero
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 14;
            Console.WriteLine(NumberOfSteps(num1));

            int num2 = 8;
            Console.WriteLine(NumberOfSteps(num2));

            int num3 = 123;
            Console.WriteLine(NumberOfSteps(num3));

            Console.ReadKey();
        }

        public static int NumberOfSteps(int num)
        {
            int output = 0;

            while (num != 0)
            {
                if (num % 2 == 0)
                {
                    num /= 2;
                }
                else
                {
                    num--;
                }
                output++;
            }

            return output;
        }
    }
}
