using System;
using System.Collections.Generic;

namespace _412._Fizz_Buzz
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1 = 3;
            Console.WriteLine(String.Join(", ", FizzBuzz(n1)));

            int n2 = 5;
            Console.WriteLine(String.Join(", ", FizzBuzz(n2)));

            int n3 = 15;
            Console.WriteLine(String.Join(", ", FizzBuzz(n3)));
        }

        public static IList<string> FizzBuzz(int n)
        {
            string[] answer = new string[n];

            for (int i = 0; i < n; i++)
            {
                if ((i + 1) % 3 == 0 && (i + 1) % 5 == 0)
                {
                    answer[i] = "FizzBuzz";
                }
                else if ((i + 1) % 3 == 0)
                {
                    answer[i] = "Fizz";
                }
                else if ((i + 1) % 5 == 0)
                {
                    answer[i] = "Buzz";
                }
                else
                {
                    answer[i] = (i + 1).ToString();
                }
            }

            return answer;
        }
    }
}
