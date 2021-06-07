using System;

namespace _461._Hamming_Distance
{
    class Program
    {
        static void Main(string[] args)
        {
            int x1 = 1;
            int y1 = 4;
            Console.WriteLine(HammingDistance1(x1, y1));
            Console.WriteLine(HammingDistance2(x1, y1));

            int x2 = 3;
            int y2 = 1;
            Console.WriteLine(HammingDistance1(x2, y2));
            Console.WriteLine(HammingDistance2(x2, y2));
        }

        public static int HammingDistance1(int x, int y)
        {
            int distance = 0;
            string xByteString = Convert.ToString(x, 2);
            string yByteString = Convert.ToString(y, 2);

            if (xByteString.Length > yByteString.Length)
            {
                yByteString = yByteString.PadLeft(xByteString.Length, '0');
            }
            else
            {
                xByteString = xByteString.PadLeft(yByteString.Length, '0');
            }

            for (int i = 0; i < xByteString.Length; i++)
            {
                if (xByteString[i] != yByteString[i])
                {
                    distance++;
                }
            }

            return distance;
        }

        public static int HammingDistance2(int x, int y)
        {
            int distance = 0;
            string xorDigits = Convert.ToString(x ^ y, 2);

            foreach (var digit in xorDigits)
            {
                if (digit == '1')
                {
                    distance++;
                }
            }

            return distance;
        }
    }
}
