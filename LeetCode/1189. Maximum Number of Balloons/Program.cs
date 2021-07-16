using System;
using System.Collections.Generic;

namespace _1189._Maximum_Number_of_Balloons
{
    class Program
    {
        static void Main(string[] args)
        {
            string text1 = "nlaebolko";
            Console.WriteLine(MaxNumberOfBalloons1(text1));
            Console.WriteLine(MaxNumberOfBalloons2(text1));
            Console.WriteLine(MaxNumberOfBalloons3(text1));

            string text2 = "loonbalxballpoon";
            Console.WriteLine(MaxNumberOfBalloons1(text2));
            Console.WriteLine(MaxNumberOfBalloons2(text2));
            Console.WriteLine(MaxNumberOfBalloons3(text2));

            string text3 = "leetcode";
            Console.WriteLine(MaxNumberOfBalloons1(text3));
            Console.WriteLine(MaxNumberOfBalloons2(text3));
            Console.WriteLine(MaxNumberOfBalloons3(text3));

            string text4 = "balon";
            Console.WriteLine(MaxNumberOfBalloons1(text4));
            Console.WriteLine(MaxNumberOfBalloons2(text4));
            Console.WriteLine(MaxNumberOfBalloons3(text4));
        }

        public static int MaxNumberOfBalloons1(string text)
        {
            Dictionary<char, int> neededLetters = new Dictionary<char, int>();
            neededLetters.Add('b', 1);
            neededLetters.Add('a', 1);
            neededLetters.Add('l', 2);
            neededLetters.Add('o', 2);
            neededLetters.Add('n', 1);

            Dictionary<char, int> letters = new Dictionary<char, int>();

            foreach (var letter in text)
            {
                if (letters.ContainsKey(letter))
                {
                    letters[letter]++;
                }
                else
                {
                    letters.Add(letter, 1);
                }
            }

            int maxBalloons = int.MaxValue;

            foreach (var kvp in neededLetters)
            {
                if (letters.ContainsKey(kvp.Key) && letters[kvp.Key] >= kvp.Value)
                {
                    maxBalloons = Math.Min(maxBalloons, letters[kvp.Key] / kvp.Value);
                }
                else
                {
                    return 0;
                }
            }

            return maxBalloons;
        }

        public static int MaxNumberOfBalloons2(string text)
        {
            int[] neededLetters = new int['z' - 'a' + 1];
            neededLetters['b' - 'a'] = 1;
            neededLetters['a' - 'a'] = 1;
            neededLetters['l' - 'a'] = 2;
            neededLetters['o' - 'a'] = 2;
            neededLetters['n' - 'a'] = 1;

            int[] letters = new int['z' - 'a' + 1];

            foreach (var letter in text)
            {
                letters[letter - 'a']++;
            }

            int maxBalloons = int.MaxValue;

            for (int i = 0; i < neededLetters.Length; i++)
            {
                if (neededLetters[i] == 0)
                {
                    continue;
                }

                if (letters[i] >= neededLetters[i])
                {
                    maxBalloons = Math.Min(maxBalloons, letters[i] / neededLetters[i]);
                }
                else
                {
                    return 0;
                }
            }

            return maxBalloons;
        }

        public static int MaxNumberOfBalloons3(string text)
        {
            int[] letters = new int['z' - 'a' + 1];

            foreach (var letter in text)
            {
                letters[letter - 'a']++;
            }

            letters['l' - 'a'] /= 2;
            letters['o' - 'a'] /= 2;

            int maxBalloons = int.MaxValue;

            foreach (var c in "balloon")
            {
                maxBalloons = Math.Min(letters[c - 'a'], maxBalloons);
            }

            return maxBalloons;
        }
    }
}
