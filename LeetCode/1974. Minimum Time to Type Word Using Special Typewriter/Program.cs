using System;

namespace _1974._Minimum_Time_to_Type_Word_Using_Special_Typewriter
{
    class Program
    {
        static void Main(string[] args)
        {
            string word1 = "abc";
            Console.WriteLine(MinTimeToType1(word1));
            Console.WriteLine(MinTimeToType2(word1));

            string word2 = "bza";
            Console.WriteLine(MinTimeToType1(word2));
            Console.WriteLine(MinTimeToType2(word2));

            string word3 = "zjpc";
            Console.WriteLine(MinTimeToType1(word3));
            Console.WriteLine(MinTimeToType2(word3));
        }

        public static int MinTimeToType1(string word)
        {
            int totalTime = 0;
            char currentLetter = 'a';

            foreach (var letterToType in word)
            {
                if (letterToType != currentLetter)
                {
                    int movesNeededRight = (int)currentLetter > (int)letterToType ? 26 - (currentLetter - letterToType) : letterToType - currentLetter;
                    int movesNeededLeft = (int)currentLetter > (int)letterToType ? currentLetter - letterToType : 26 - (letterToType - currentLetter);
                    int movesNeeded = Math.Min(movesNeededRight, movesNeededLeft);

                    totalTime += movesNeeded + 1;
                    currentLetter = letterToType;
                }
                else
                {
                    totalTime++;
                }
            }

            return totalTime;
        }

        public static int MinTimeToType2(string word)
        {
            int totalTime = 0;
            char currentLetter = 'a';

            foreach (var letterToType in word)
            {
                int movesNeededRight = (letterToType - currentLetter + 26) % 26;
                int movesNeededLeft = (currentLetter - letterToType + 26) % 26;
                int movesNeeded = Math.Min(movesNeededRight, movesNeededLeft);

                totalTime += movesNeeded + 1;
                currentLetter = letterToType;
            }

            return totalTime;
        }
    }
}
