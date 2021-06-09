using System;

namespace _1217._Minimum_Cost_to_Move_Chips_to_The_Same_Position
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] position1 = { 2, 2, 2, 3, 3 };
            Console.WriteLine(MinCostToMoveChips(position1));

            int[] position2 = { 2, 2, 2, 3, 3 };
            Console.WriteLine(MinCostToMoveChips(position2));

            int[] position3 = { 1, 1000000000 };
            Console.WriteLine(MinCostToMoveChips(position3));
        }

        public static int MinCostToMoveChips(int[] position)
        {
            int evenPositionChips = 0;

            foreach (var pos in position)
            {
                if (pos % 2 == 1)
                {
                    evenPositionChips++;
                }
            }

            return Math.Min(evenPositionChips, position.Length - evenPositionChips);
        }
    }
}
