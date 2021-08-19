using System;

namespace _292._Nim_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1 = 4;
            Console.WriteLine(CanWinNim1(n1));
            Console.WriteLine(CanWinNim2(n1));
            Console.WriteLine(CanWinNim3(n1));
            Console.WriteLine(CanWinNim4(n1));

            int n2 = 1;
            Console.WriteLine(CanWinNim1(n2));
            Console.WriteLine(CanWinNim2(n2));
            Console.WriteLine(CanWinNim3(n2));
            Console.WriteLine(CanWinNim4(n2));

            int n3 = 2;
            Console.WriteLine(CanWinNim1(n3));
            Console.WriteLine(CanWinNim2(n3));
            Console.WriteLine(CanWinNim3(n3));
            Console.WriteLine(CanWinNim4(n3));

            int n4 = 8;
            Console.WriteLine(CanWinNim1(n4));
            Console.WriteLine(CanWinNim2(n4));
            Console.WriteLine(CanWinNim3(n4));
            Console.WriteLine(CanWinNim4(n4));

            int n5 = 45;
            //Console.WriteLine(CanWinNim1(n5));
            Console.WriteLine(CanWinNim2(n5));
            Console.WriteLine(CanWinNim3(n5));
            Console.WriteLine(CanWinNim4(n5));

            int n6 = 1348820612;
            //Console.WriteLine(CanWinNim1(n5));
            //Console.WriteLine(CanWinNim2(n6));
            Console.WriteLine(CanWinNim3(n6));
            Console.WriteLine(CanWinNim4(n6));
        }

        public static bool CanWinNim1(int n)
        {
            if (n <= 3)
            {
                return true;
            }

            if (n == 4)
            {
                return false;
            }

            return !CanWinNim1(n - 1) || !CanWinNim1(n - 2) || !CanWinNim1(n - 3);
        }

        public static bool CanWinNim2(int n)
        {
            if (n <= 3)
            {
                return true;
            }

            bool[] isWinningMove = new bool[n];
            isWinningMove[0] = true;
            isWinningMove[1] = true;
            isWinningMove[2] = true;

            for (int i = 4; i <= n; i++)
            {
                isWinningMove[i - 1] = !isWinningMove[i - 2] || !isWinningMove[i - 3] || !isWinningMove[i - 4];
            }

            return isWinningMove[n - 1];
        }

        public static bool CanWinNim3(int n)
        {
            if (n <= 3)
            {
                return true;
            }

            bool first = true;
            bool second = true;
            bool third = true;
            bool current = false;

            for (int i = 4; i <= n; i++)
            {
                current = !first || !second || !third;

                first = second;
                second = third;
                third = current;
            }

            return current;
        }

        public static bool CanWinNim4(int n)
        {
            return n % 4 != 0;
        }
    }
}
