using System;

namespace _121._Best_Time_to_Buy_and_Sell_Stock
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] prices1 = { 7, 1, 5, 3, 6, 4 };
            Console.WriteLine(MaxProfit1(prices1));
            Console.WriteLine(MaxProfit2(prices1));

            int[] prices2 = { 7, 6, 4, 3, 1 };
            Console.WriteLine(MaxProfit1(prices2));
            Console.WriteLine(MaxProfit2(prices2));
        }

        public static int MaxProfit1(int[] prices)
        {
            int maximumProfit = 0;

            for (int i = 0; i < prices.Length - 1; i++)
            {
                for (int j = i + 1; j < prices.Length; j++)
                {
                    if (prices[i] < prices[j])
                    {
                        maximumProfit = Math.Max(maximumProfit, prices[j] - prices[i]);
                    }
                }
            }

            return maximumProfit;
        }

        public static int MaxProfit2(int[] prices)
        {
            int minimumPrice = int.MaxValue;
            int maximumProfit = 0;

            for (int i = 0; i < prices.Length; i++)
            {
                if (prices[i] < minimumPrice)
                {
                    minimumPrice = prices[i];
                }
                else if (prices[i] - minimumPrice > maximumProfit)
                {
                    maximumProfit = prices[i] - minimumPrice;
                }
            }

            return maximumProfit;
        }
    }
}
