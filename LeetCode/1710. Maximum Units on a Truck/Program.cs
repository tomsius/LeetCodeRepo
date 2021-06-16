using System;
using System.Linq;

namespace _1710._Maximum_Units_on_a_Truck
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][] boxTypes1 = new int[][]
            {
                new int[] { 1, 3 },
                new int[] { 2, 2 },
                new int[] { 3, 1 }
            };
            int truckSize1 = 4;
            Console.WriteLine(MaximumUnits(boxTypes1, truckSize1));

            int[][] boxTypes2 = new int[][]
            {
                new int[] { 5, 10 },
                new int[] { 2, 5 },
                new int[] { 4, 7 },
                new int[] { 3, 9 }
            };
            int truckSize2 = 10;
            Console.WriteLine(MaximumUnits(boxTypes2, truckSize2));
        }

        public static int MaximumUnits(int[][] boxTypes, int truckSize)
        {
            int maximumNumberOfUnits = 0;
            boxTypes = boxTypes.OrderByDescending(box => box[1]).ToArray();

            for (int i = 0; i < boxTypes.Length; i++)
            {
                if (truckSize == 0)
                {
                    break;
                }

                if (boxTypes[i][0] > truckSize)
                {
                    maximumNumberOfUnits += (boxTypes[i][0] - (boxTypes[i][0] - truckSize)) * boxTypes[i][1];
                    truckSize -= (boxTypes[i][0] - (boxTypes[i][0] - truckSize));
                }
                else
                {
                    maximumNumberOfUnits += boxTypes[i][0] * boxTypes[i][1];
                    truckSize -= boxTypes[i][0];
                }
            }

            return maximumNumberOfUnits;
        }
    }
}
