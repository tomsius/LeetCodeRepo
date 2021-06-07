using System;

namespace _1742._Maximum_Number_of_Balls_in_a_Box
{
    class Program
    {
        static void Main(string[] args)
        {
            int lowLimit1 = 1;
            int highLimit1 = 10;
            Console.WriteLine(CountBalls1(lowLimit1, highLimit1));
            Console.WriteLine(CountBalls2(lowLimit1, highLimit1));

            int lowLimit2 = 5;
            int highLimit2 = 15;
            Console.WriteLine(CountBalls1(lowLimit2, highLimit2));
            Console.WriteLine(CountBalls2(lowLimit2, highLimit2));

            int lowLimit3 = 19;
            int highLimit3 = 28;
            Console.WriteLine(CountBalls1(lowLimit3, highLimit3));
            Console.WriteLine(CountBalls2(lowLimit3, highLimit3));
        }

        public static int CountBalls1(int lowLimit, int highLimit)
        {
            int[] ballCount = new int[100000];
            int maxCountBox = 0;

            for (int number = lowLimit; number <= highLimit; number++)
            {
                int digitSum = 0;

                foreach (var digit in number.ToString())
                {
                    digitSum += int.Parse(digit.ToString());
                }

                ballCount[digitSum - 1]++;

                if (ballCount[digitSum - 1] > ballCount[maxCountBox])
                {
                    maxCountBox = digitSum - 1;
                }
            }

            return ballCount[maxCountBox];
        }

        public static int CountBalls2(int lowLimit, int highLimit)
        {
            int[] ballCount = new int[100000];
            int maxCountBox = 0;

            for (int number = lowLimit; number <= highLimit; number++)
            {
                int digitSum = 0;
                int tempNumber = number;

                while (tempNumber > 0)
                {
                    digitSum += tempNumber % 10;
                    tempNumber /= 10;
                }

                ballCount[digitSum - 1]++;

                if (ballCount[digitSum - 1] > ballCount[maxCountBox])
                {
                    maxCountBox = digitSum - 1;
                }
            }

            return ballCount[maxCountBox];
        }
    }
}
