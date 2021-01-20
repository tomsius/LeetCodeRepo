using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1528.Shuffle_String
{
    class Program
    {
        static void Main(string[] args)
        {
            string s1 = "codeleet";
            int[] indices1 = { 4, 5, 6, 7, 0, 2, 1, 3 };
            Console.WriteLine(RestoreString(s1, indices1));
            Console.WriteLine(RestoreString2(s1, indices1));
            Console.WriteLine(RestoreString3(s1, indices1));

            string s2 = "abc";
            int[] indices2 = { 0, 1, 2 };
            Console.WriteLine(RestoreString(s2, indices2));
            Console.WriteLine(RestoreString2(s2, indices2));
            Console.WriteLine(RestoreString3(s2, indices2));

            string s3 = "aiohn";
            int[] indices3 = { 3, 1, 4, 2, 0 };
            Console.WriteLine(RestoreString(s3, indices3));
            Console.WriteLine(RestoreString2(s3, indices3));
            Console.WriteLine(RestoreString3(s3, indices3));

            string s4 = "aaiougrt";
            int[] indices4 = { 4, 0, 2, 6, 7, 3, 1, 5 };
            Console.WriteLine(RestoreString(s4, indices4));
            Console.WriteLine(RestoreString2(s4, indices4));
            Console.WriteLine(RestoreString3(s4, indices4));

            string s5 = "art";
            int[] indices5 = { 1, 0, 2 };
            Console.WriteLine(RestoreString(s5, indices5));
            Console.WriteLine(RestoreString2(s5, indices5));
            Console.WriteLine(RestoreString3(s5, indices5));

            Console.ReadKey();
        }

        public static string RestoreString(string s, int[] indices)
        {
            char[] characters = s.ToCharArray();

            for (int i = 0; i < indices.Length; i++)
            {
                characters[indices[i]] = s[i];
            }

            return new string(characters);
        }

        public static string RestoreString2(string s, int[] indices)
        {
            StringBuilder sb = new StringBuilder(new string(' ', indices.Length));

            for (int i = 0; i < indices.Length; i++)
            {
                sb.Insert(indices[i], s[i]);
                sb.Remove(indices[i] + 1, 1);
            }

            return sb.ToString();
        }

        public static string RestoreString3(string s, int[] indices)
        {
            char[] characters = s.ToCharArray();

            Array.Sort(indices, characters);

            return new string(characters);
        }
    }
}
