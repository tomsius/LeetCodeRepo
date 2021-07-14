using System;

namespace _1716._Calculate_Money_in_Leetcode_Bank
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1 = 4;
            Console.WriteLine(TotalMoney1(n1));
            Console.WriteLine(TotalMoney2(n1));
            Console.WriteLine(TotalMoney3(n1));

            int n2 = 10;
            Console.WriteLine(TotalMoney1(n2));
            Console.WriteLine(TotalMoney2(n2));
            Console.WriteLine(TotalMoney3(n2));

            int n3 = 20;
            Console.WriteLine(TotalMoney1(n3));
            Console.WriteLine(TotalMoney2(n3));
            Console.WriteLine(TotalMoney3(n3));
        }

        public static int TotalMoney1(int n)
        {
            int totalMoney = 0;
            int mondayMoney = 1;
            int moneyToPay = mondayMoney;
            int weekDay = 1;

            while (n > 0)
            {
                totalMoney += moneyToPay;
                moneyToPay++;

                if (weekDay == 7)
                {
                    mondayMoney++;
                    moneyToPay = mondayMoney;
                    weekDay = 0;
                }

                weekDay++;
                n--;
            }

            return totalMoney;
        }

        public static int TotalMoney2(int n)
        {
            int totalMoney = 0;
            int moneyToPay = 1;
            int weekDay = 1;

            while (n > 0)
            {
                totalMoney += moneyToPay;
                moneyToPay++;
                weekDay++;

                if (weekDay == 8)
                {
                    moneyToPay -= 6;
                    weekDay = 1;
                }

                n--;
            }

            return totalMoney;
        }

        public static int TotalMoney3(int n)
        {
            int k = n / 7;
            int x = n % 7;

            return (7 * k * (k + 7) / 2) + (x * (2 * k + x + 1) / 2);
        }
    }
}
