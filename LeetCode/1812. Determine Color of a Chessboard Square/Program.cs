using System;

namespace _1812._Determine_Color_of_a_Chessboard_Square
{
    class Program
    {
        static void Main(string[] args)
        {
            string coordinates1 = "a1";
            Console.WriteLine(SquareIsWhite1(coordinates1));
            Console.WriteLine(SquareIsWhite2(coordinates1));

            string coordinates2 = "h3";
            Console.WriteLine(SquareIsWhite1(coordinates2));
            Console.WriteLine(SquareIsWhite2(coordinates2));

            string coordinates3 = "c7";
            Console.WriteLine(SquareIsWhite1(coordinates3));
            Console.WriteLine(SquareIsWhite2(coordinates3));
        }

        public static bool SquareIsWhite1(string coordinates)
        {
            int col = coordinates[0] - 'a';
            int row = int.Parse(coordinates[1].ToString());

            if ((col % 2 == 0 && row % 2 == 1) || (col % 2 == 1 && row % 2 == 0))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public static bool SquareIsWhite2(string coordinates)
        {
            int col = coordinates[0] - 'a';
            int row = coordinates[1] - '0';

            return !((col % 2 == 0 && row % 2 == 1) || (col % 2 == 1 && row % 2 == 0));
        }
    }
}
