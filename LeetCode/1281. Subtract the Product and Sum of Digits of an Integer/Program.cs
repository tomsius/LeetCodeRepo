using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1281.Subtract_the_Product_and_Sum_of_Digits_of_an_Integer
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1 = 234;
            Console.WriteLine(SubtractProductAndSum(n1));

            int n2 = 4421;
            Console.WriteLine(SubtractProductAndSum(n2));

            Console.ReadKey();
        }

        public static int SubtractProductAndSum(int n)
        {
            int product = 1;
            int sum = 0;

            while (n > 0)
            {
                product *= (n % 10);
                sum += (n % 10);

                n /= 10;
            }

            return product - sum;
        }
    }
}
