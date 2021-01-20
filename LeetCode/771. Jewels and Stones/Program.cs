using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _771.Jewels_and_Stones
{
    class Program
    {
        static void Main(string[] args)
        {
            string J1 = "aA";
            string S1 = "aAAbbbb";
            Console.WriteLine(NumJewelsInStones(J1, S1));
            Console.WriteLine(NumJewelsInStones2(J1, S1));
            Console.WriteLine(NumJewelsInStones3(J1, S1));

            string J2 = "z";
            string S2 = "ZZ";
            Console.WriteLine(NumJewelsInStones(J2, S2));
            Console.WriteLine(NumJewelsInStones2(J2, S2));
            Console.WriteLine(NumJewelsInStones3(J2, S2));

            Console.ReadKey();
        }

        public static int NumJewelsInStones(string J, string S)
        {
            int output = 0;
            HashSet<char> jewels = new HashSet<char>(J);

            for (int i = 0; i < S.Length; i++)
            {
                if (jewels.Contains(S[i]))
                {
                    output++;
                }
            }

            return output;
        }

        public static int NumJewelsInStones2(string J, string S)
        {
            int output = 0;
            char[] stonesLowercase = new char['z' - 'a' + 1];
            char[] stonesUppercase = new char['Z' - 'A' + 1];

            for (int i = 0; i < S.Length; i++)
            {
                if (char.IsUpper(S[i]))
                {
                    stonesUppercase[S[i] - 'A']++;
                }
                else
                {
                    stonesLowercase[S[i] - 'a']++;
                }
            }

            for (int i = 0; i < J.Length; i++)
            {
                if (char.IsUpper(J[i]))
                {
                    output += stonesUppercase[J[i] - 'A'];
                }
                else
                {
                    output += stonesLowercase[J[i] - 'a'];
                }
            }

            return output;
        }

        public static int NumJewelsInStones3(string J, string S)
        {
            int output = 0;
            char[] stones = new char[('z' - 'a' + 1) * 2];

            for (int i = 0; i < S.Length; i++)
            {
                if (char.IsUpper(S[i]))
                {
                    stones[S[i] - 'A' + 26]++;
                }
                else
                {
                    stones[S[i] - 'a']++;
                }
            }

            for (int i = 0; i < J.Length; i++)
            {
                if (char.IsUpper(J[i]))
                {
                    output += stones[J[i] - 'A' + 26];
                }
                else
                {
                    output += stones[J[i] - 'a'];
                }
            }

            return output;
        }
    }
}
