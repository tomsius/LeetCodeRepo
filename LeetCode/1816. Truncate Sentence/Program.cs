using System;
using System.Text;

namespace _1816._Truncate_Sentence
{
    class Program
    {
        static void Main(string[] args)
        {
            string s1 = "Hello how are you Contestant";
            int k1 = 4;
            Console.WriteLine(TruncateSentence(s1, k1));

            string s2 = "What is the solution to this problem";
            int k2 = 4;
            Console.WriteLine(TruncateSentence(s2, k2));

            string s3 = "chopper is not a tanuki";
            int k3 = 5;
            Console.WriteLine(TruncateSentence(s3, k3));
        }

        public static string TruncateSentence(string s, int k)
        {
            string[] words = s.Split(" ");

            return string.Join(" ", words, 0, k);
        }
    }
}
