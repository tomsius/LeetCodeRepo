using System;

namespace _1475._Final_Prices_With_a_Special_Discount_in_a_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] prices1 = { 8, 4, 6, 2, 3 };
            Console.WriteLine(string.Join(" ", FinalPrices(prices1)));

            int[] prices2 = { 1, 2, 3, 4, 5 };
            Console.WriteLine(string.Join(" ", FinalPrices(prices2)));

            int[] prices3 = { 10, 1, 1, 6 };
            Console.WriteLine(string.Join(" ", FinalPrices(prices3)));
        }

        public static int[] FinalPrices(int[] prices)
        {
            for (int i = 0; i < prices.Length - 1; i++)
            {
                for (int j = i + 1; j < prices.Length; j++)
                {
                    if (prices[j] <= prices[i])
                    {
                        prices[i] = prices[i] - prices[j];
                        break;
                    }
                }
            }

            return prices;
        }
    }
}
