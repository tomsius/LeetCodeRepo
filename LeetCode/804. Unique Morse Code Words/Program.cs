using System;
using System.Collections.Generic;
using System.Text;

namespace _804._Unique_Morse_Code_Words
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = { "gin", "zen", "gig", "msg" };
            Console.WriteLine(UniqueMorseRepresentations(words));
        }

        public static int UniqueMorseRepresentations(string[] words)
        {
            HashSet<string> uniqueTransformations = new HashSet<string>();
            string[] morseTable = { ".-", "-...", "-.-.", "-..", ".", "..-.", "--.", "....", "..", ".---", "-.-", ".-..", "--", "-.", "---", ".--.", "--.-", ".-.", "...", "-", "..-", "...-", ".--", "-..-", "-.--", "--.." };

            foreach (var word in words)
            {
                StringBuilder sb = new StringBuilder();

                foreach (var letter in word)
                {
                    sb.Append(morseTable[letter - 'a']);
                }

                uniqueTransformations.Add(sb.ToString());
            }

            return uniqueTransformations.Count;
        }
    }
}
