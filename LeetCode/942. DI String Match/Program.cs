using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _942.DI_String_Match
{
    class Program
    {
        static void Main(string[] args)
        {
            string s1 = "IDID";
            Console.WriteLine(string.Join("", DiStringMatch(s1)));

            string s2 = "III";
            Console.WriteLine(string.Join("", DiStringMatch(s2)));

            string s3 = "DDI";
            Console.WriteLine(string.Join("", DiStringMatch(s3)));

            Console.ReadKey();
        }

        public static int[] DiStringMatch(string S)
        {
            int[] output = new int[S.Length + 1];
            int max = S.Length;
            int min = 0;

            for (int i = 0; i < S.Length; i++)
            {
                if (S[i].Equals('D'))
                {
                    output[i] = max--;
                }
                else
                {
                    output[i] = min++;
                }
            }

            output[S.Length] = min;

            return output;
        }
    }
}
