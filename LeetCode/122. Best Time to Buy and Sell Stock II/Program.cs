using System;

namespace _122._Best_Time_to_Buy_and_Sell_Stock_II
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] prices1 = { 7, 1, 5, 3, 6, 4 };
            Console.WriteLine(MaxProfit1(prices1));
            Console.WriteLine(MaxProfit2(prices1));

            int[] prices2 = { 1, 2, 3, 4, 5 };
            Console.WriteLine(MaxProfit1(prices2));
            Console.WriteLine(MaxProfit2(prices2));

            int[] prices3 = { 7, 6, 4, 3, 1 };
            Console.WriteLine(MaxProfit1(prices3));
            Console.WriteLine(MaxProfit2(prices3));
        }

        public static int MaxProfit1(int[] prices)
        {
            int i = 0;
            int minimumValue = prices[0];
            int maximumValue = prices[0];
            int maximumPprofit = 0;

            while (i < prices.Length - 1)
            {
                // price is going down
                while (i < prices.Length - 1 && prices[i] >= prices[i + 1])
                {
                    i++;
                }
                    
                minimumValue = prices[i];

                // price is going up
                while (i < prices.Length - 1 && prices[i] <= prices[i + 1])
                {
                    i++;
                }
                    
                maximumValue = prices[i];
                maximumPprofit += maximumValue - minimumValue;
            }

            return maximumPprofit;
        }

        public static int MaxProfit2(int[] prices)
        {
            int maximumPprofit = 0;

            for (int i = 0; i < prices.Length - 1; i++)
            {
                if (prices[i] < prices[i + 1])
                {
                    maximumPprofit += prices[i + 1] - prices[i];
                }
            }

            return maximumPprofit;
        }
    }
}
