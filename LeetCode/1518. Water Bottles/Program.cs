using System;

namespace _1518._Water_Bottles
{
    class Program
    {
        static void Main(string[] args)
        {
            int numBottles1 = 9;
            int numExchange1 = 3;
            Console.WriteLine(NumWaterBottles1(numBottles1, numExchange1));
            Console.WriteLine(NumWaterBottles2(numBottles1, numExchange1));
            Console.WriteLine(NumWaterBottles3(numBottles1, numExchange1));

            int numBottles2 = 15;
            int numExchange2 = 4;
            Console.WriteLine(NumWaterBottles1(numBottles2, numExchange2));
            Console.WriteLine(NumWaterBottles2(numBottles2, numExchange2));
            Console.WriteLine(NumWaterBottles3(numBottles2, numExchange2));

            int numBottles3 = 5;
            int numExchange3 = 5;
            Console.WriteLine(NumWaterBottles1(numBottles3, numExchange3));
            Console.WriteLine(NumWaterBottles2(numBottles3, numExchange3));
            Console.WriteLine(NumWaterBottles3(numBottles3, numExchange3));

            int numBottles4 = 2;
            int numExchange4 = 3;
            Console.WriteLine(NumWaterBottles1(numBottles4, numExchange4));
            Console.WriteLine(NumWaterBottles2(numBottles4, numExchange4));
            Console.WriteLine(NumWaterBottles3(numBottles4, numExchange4));
        }

        public static int NumWaterBottles1(int numBottles, int numExchange)
        {
            int drunkBottles = numBottles;
            int emptyBottles = numBottles;

            while (emptyBottles / numExchange > 0)
            {
                drunkBottles += emptyBottles / numExchange;
                emptyBottles = emptyBottles + (emptyBottles / numExchange) - (numExchange * (emptyBottles / numExchange));
            }

            return drunkBottles;
        }

        public static int NumWaterBottles2(int numBottles, int numExchange)
        {
            int drunkBottles = 0;

            for (int i = 0; i < numBottles; i++)
            {
                drunkBottles++;

                if (drunkBottles % numExchange == 0)
                {
                    drunkBottles++;
                }
            }

            return drunkBottles;
        }

        public static int NumWaterBottles3(int numBottles, int numExchange)
        {
            int drunkBottles = numBottles;
            int emptyBottles = numBottles;

            while (emptyBottles >= numExchange)
            {
                drunkBottles += emptyBottles / numExchange;
                emptyBottles = emptyBottles / numExchange + emptyBottles % numExchange;
            }

            return drunkBottles;
        }
    }
}
