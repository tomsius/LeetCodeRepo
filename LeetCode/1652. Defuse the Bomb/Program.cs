using System;
using System.Linq;

namespace _1652._Defuse_the_Bomb
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] code1 = { 5, 7, 1, 4 };
            int k1 = 3;
            Console.WriteLine(String.Join(", ", Decrypt1(code1, k1)));
            Console.WriteLine(String.Join(", ", Decrypt2(code1, k1)));

            int[] code2 = { 1, 2, 3, 4 };
            int k2 = 0;
            Console.WriteLine(String.Join(", ", Decrypt1(code2, k2)));
            Console.WriteLine(String.Join(", ", Decrypt2(code2, k2)));

            int[] code3 = { 2, 4, 9, 3 };
            int k3 = -2;
            Console.WriteLine(String.Join(", ", Decrypt1(code3, k3)));
            Console.WriteLine(String.Join(", ", Decrypt2(code3, k3)));
        }

        public static int[] Decrypt1(int[] code, int k)
        {
            if (k == 0)
            {
                return new int[code.Length];
            }

            int[] decoded = new int[code.Length];

            for (int i = 0; i < decoded.Length; i++)
            {
                if (k > 0)
                {
                    decoded[i] = SumToRight(code, i, Math.Abs(k));
                }
                else
                {
                    decoded[i] = SumToLeft(code, i, Math.Abs(k));
                }
            }

            return decoded;
        }

        private static int SumToRight(int[] code, int index, int k)
        {
            int sum = 0;

            for (int i = 0; i < k; i++)
            {
                index++;

                if (index == code.Length)
                {
                    index = 0;
                }

                sum += code[index];
            }

            return sum;
        }

        private static int SumToLeft(int[] code, int index, int k)
        {
            int sum = 0;

            for (int i = 0; i < k; i++)
            {
                index--;

                if (index < 0)
                {
                    index = code.Length - 1;
                }

                sum += code[index];
            }

            return sum;
        }

        public static int[] Decrypt2(int[] code, int k)
        {
            if (k == 0)
            {
                return new int[code.Length];
            }

            int[] decoded = new int[code.Length];

            for (int i = 0; i < decoded.Length; i++)
            {
                if (k > 0)
                {
                    decoded[i] = GetSum(code, i, 1, Math.Abs(k));
                }
                else
                {
                    decoded[i] = GetSum(code, i, -1, Math.Abs(k));
                }
            }

            return decoded;
        }

        private static int GetSum(int[] code, int index, int deltaIndex, int k)
        {
            int sum = 0;

            for (int i = 0; i < k; i++)
            {
                index += deltaIndex;

                if (index == code.Length)
                {
                    index = 0;
                }
                else if (index < 0)
                {
                    index = code.Length - 1;
                }

                sum += code[index];
            }

            return sum;
        }
    }
}
