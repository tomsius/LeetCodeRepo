using System;

namespace _520._Detect_Capital
{
    class Program
    {
        static void Main(string[] args)
        {
            string word1 = "USA";
            Console.WriteLine(DetectCapitalUse1(word1));
            Console.WriteLine(DetectCapitalUse2(word1));
            Console.WriteLine(DetectCapitalUse3(word1));
            Console.WriteLine(DetectCapitalUse4(word1));

            string word2 = "FlaG";
            Console.WriteLine(DetectCapitalUse1(word2));
            Console.WriteLine(DetectCapitalUse2(word2));
            Console.WriteLine(DetectCapitalUse3(word2));
            Console.WriteLine(DetectCapitalUse4(word2));

            string word3 = "leetcode";
            Console.WriteLine(DetectCapitalUse1(word3));
            Console.WriteLine(DetectCapitalUse2(word3));
            Console.WriteLine(DetectCapitalUse3(word3));
            Console.WriteLine(DetectCapitalUse4(word3));

            string word4 = "Google";
            Console.WriteLine(DetectCapitalUse1(word4));
            Console.WriteLine(DetectCapitalUse2(word4));
            Console.WriteLine(DetectCapitalUse3(word4));
            Console.WriteLine(DetectCapitalUse4(word4));

            string word5 = "GG";
            Console.WriteLine(DetectCapitalUse1(word5));
            Console.WriteLine(DetectCapitalUse2(word5));
            Console.WriteLine(DetectCapitalUse3(word5));
            Console.WriteLine(DetectCapitalUse4(word5));

            string word6 = "ffffffffffffffffffffF";
            Console.WriteLine(DetectCapitalUse1(word6));
            Console.WriteLine(DetectCapitalUse2(word6));
            Console.WriteLine(DetectCapitalUse3(word6));
            Console.WriteLine(DetectCapitalUse4(word6));
        }

        public static bool DetectCapitalUse1(string word)
        {
            bool areAllUpper = true;
            bool areAllLower = true;
            bool isOnlyFirstUpper = true;

            foreach (var letter in word)
            {
                if (char.IsLower(letter))
                {
                    areAllUpper = false;

                    break;
                }
            }

            if (areAllUpper)
            {
                return true;
            }

            foreach (var letter in word)
            {
                if (char.IsUpper(letter))
                {
                    areAllLower = false;

                    break;
                }
            }

            if (areAllLower)
            {
                return true;
            }

            if (char.IsLower(word[0]))
            {
                isOnlyFirstUpper = false;
            }

            if (isOnlyFirstUpper)
            {
                for (int i = 1; i < word.Length; i++)
                {
                    if (char.IsUpper(word[i]))
                    {
                        isOnlyFirstUpper = false;

                        break;
                    }
                }
            }

            if (isOnlyFirstUpper)
            {
                return true;
            }

            return false;
        }

        public static bool DetectCapitalUse2(string word)
        {
            if (word.Length == 1)
            {
                return true;
            }

            if (char.IsUpper(word[0]) && char.IsUpper(word[1]))
            {
                for (int i = 2; i < word.Length; i++)
                {
                    if (char.IsLower(word[i]))
                    {
                        return false;
                    }
                }
            }
            else
            {
                for (int i = 1; i < word.Length; i++)
                {
                    if (char.IsUpper(word[i]))
                    {
                        return false;
                    }
                }
            }

            return true;
        }

        public static bool DetectCapitalUse3(string word)
        {
            int upperCount = 0;

            foreach (var letter in word)
            {
                if (char.IsUpper(letter))
                {
                    upperCount++;
                }
            }

            if (upperCount == word.Length || upperCount == 0)
            {
                return true;
            }
            
            if (upperCount == 1)
            {
                return char.IsUpper(word[0]);
            }

            return false;
        }

        public static bool DetectCapitalUse4(string word)
        {
            if (word.Length == 1)
            {
                return true;
            }

            bool isLower = char.IsLower(word[0]) || char.IsLower(word[1]);

            for (int i = 1; i < word.Length; i++)
            {
                if (char.IsLower(word[i]) != isLower)
                {
                    return false;
                }
            }

            return true;
        }
    }
}
