using System;
using System.Text;

namespace _1374._Generate_a_String_With_Characters_That_Have_Odd_Counts
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1 = 4;
            Console.WriteLine(GenerateTheString(n1));

            int n2 = 2;
            Console.WriteLine(GenerateTheString(n2));

            int n3 = 7;
            Console.WriteLine(GenerateTheString(n3));
        }

        public static string GenerateTheString(int n)
        {
            StringBuilder sb = new StringBuilder();

            if (n % 2 == 1)
            {
                sb.Append('a', n);
            }
            else
            {
                sb.Append('a', n - 1);
                sb.Append('b');
            }

            return sb.ToString();
        }
    }
}
