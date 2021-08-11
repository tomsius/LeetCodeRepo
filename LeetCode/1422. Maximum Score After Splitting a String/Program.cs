using System;

namespace _1422._Maximum_Score_After_Splitting_a_String
{
    class Program
    {
        static void Main(string[] args)
        {
            string s1 = "011101";
            Console.WriteLine(MaxScore(s1));

            string s2 = "00111";
            Console.WriteLine(MaxScore(s2));

            string s3 = "1111";
            Console.WriteLine(MaxScore(s3));

            string s4 = "00";
            Console.WriteLine(MaxScore(s4));
        }

        public static int MaxScore(string s)
        {
            int leftScore = s[0] == '0' ? 1 : 0;
            int rightScore = 0;

            for (int i = 1; i < s.Length; i++)
            {
                if (s[i] == '1')
                {
                    rightScore++;
                }
            }

            int maximumScore = leftScore + rightScore;

            for (int i = 1; i < s.Length - 1; i++)
            {
                if (s[i] == '0')
                {
                    leftScore++;
                }
                else
                {
                    rightScore--;
                }

                maximumScore = Math.Max(maximumScore, leftScore + rightScore);
            }

            return maximumScore;
        }
    }
}
