using System;
using System.Text;

namespace _824._Goat_Latin
{
    class Program
    {
        static void Main(string[] args)
        {
            string sentence1 = "I speak Goat Latin";
            Console.WriteLine(ToGoatLatin(sentence1));

            string sentence2 = "The quick brown fox jumped over the lazy dog";
            Console.WriteLine(ToGoatLatin(sentence2));

            string sentence3 = "Each word consists of lowercase and uppercase letters only";
            Console.WriteLine(ToGoatLatin(sentence3));
        }

        public static string ToGoatLatin(string sentence)
        {
            StringBuilder sb = new StringBuilder();
            string[] words = sentence.Split(' ');

            for (int i = 0; i < words.Length; i++)
            {
                StringBuilder word = new StringBuilder();

                if (IsVowel(words[i][0]))
                {
                    word.Append(words[i]);
                }
                else
                {
                    word.Append(words[i].Substring(1));
                    word.Append(words[i][0]);
                }

                word.Append("ma");
                word.Append('a', i + 1);

                sb.Append(word);
                sb.Append(' ');
            }

            sb.Remove(sb.Length - 1, 1);

            return sb.ToString();
        }

        private static bool IsVowel(char letter)
        {
            switch (char.ToLower(letter))
            {
                case 'a':
                case 'e':
                case 'i':
                case 'o':
                case 'u':
                    return true;
                default:
                    return false;
            }
        }
    }
}
