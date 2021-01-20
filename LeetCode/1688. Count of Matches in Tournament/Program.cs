using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1688.Count_of_Matches_in_Tournament
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1 = 7;
            Console.WriteLine(NumberOfMatches(n1));

            int n2 = 14;
            Console.WriteLine(NumberOfMatches(n2));

            Console.ReadKey();
        }

        public static int NumberOfMatches(int n)
        {
            int output = 0;

            while (n > 1)
            {
                if (n % 2 == 0)
                {
                    output += n / 2;
                    n /= 2;
                }
                else
                {
                    output += (n - 1) / 2;
                    n = (n - 1) / 2 + 1;
                }
            }

            return output;
        }
    }
}
