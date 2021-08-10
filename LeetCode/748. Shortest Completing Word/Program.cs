using System;

namespace _748._Shortest_Completing_Word
{
    class Program
    {
        static void Main(string[] args)
        {
            string licensePlate1 = "1s3 PSt";
            string[] words1 = { "step", "steps", "stripe", "stepple" };
            Console.WriteLine(ShortestCompletingWord(licensePlate1, words1));

            string licensePlate2 = "1s3 456";
            string[] words2 = { "looks", "pest", "stew", "show" };
            Console.WriteLine(ShortestCompletingWord(licensePlate2, words2));

            string licensePlate3 = "Ah71752";
            string[] words3 = { "suggest", "letter", "of", "husband", "easy", "education", "drug", "prevent", "writer", "old" };
            Console.WriteLine(ShortestCompletingWord(licensePlate3, words3));

            string licensePlate4 = "OgEu755";
            string[] words4 = { "enough", "these", "play", "wide", "wonder", "box", "arrive", "money", "tax", "thus" };
            Console.WriteLine(ShortestCompletingWord(licensePlate4, words4));

            string licensePlate5 = "iMSlpe4";
            string[] words5 = { "claim", "consumer", "student", "camera", "public", "never", "wonder", "simple", "thought", "use" };
            Console.WriteLine(ShortestCompletingWord(licensePlate5, words5));
        }

        public static string ShortestCompletingWord(string licensePlate, string[] words)
        {
            int[] letters = new int['z' - 'a' + 1];

            foreach (var character in licensePlate)
            {
                if (char.IsLetter(character))
                {
                    letters[char.ToLower(character) - 'a']++;
                }
            }

            string shortestCompletingWord = "";

            foreach (var word in words)
            {
                if (IsWordCompleting(letters, word) && (shortestCompletingWord.Length == 0 || shortestCompletingWord.Length > word.Length))
                {
                    shortestCompletingWord = word;
                }
            }

            return shortestCompletingWord;
        }

        private static bool IsWordCompleting(int[] letters, string word)
        {
            int[] wordLetters = new int['z' - 'a' + 1];

            foreach (var character in word)
            {
                wordLetters[character - 'a']++;
            }

            for (int i = 0; i < letters.Length; i++)
            {
                if (letters[i] > wordLetters[i])
                {
                    return false;
                }
            }

            return true;
        }
    }
}
