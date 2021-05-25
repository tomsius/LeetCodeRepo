using System;

namespace _1720._Decode_XORed_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input1 = { 1, 2, 3 };
            int first1 = 1;
            Console.WriteLine(string.Join(" ", Decode(input1, first1)));

            int[] input2 = { 6, 2, 7, 3 };
            int first2 = 4;
            Console.WriteLine(string.Join(" ", Decode(input2, first2)));
        }

        public static int[] Decode(int[] encoded, int first)
        {
            int[] array = new int[encoded.Length + 1];
            array[0] = first;

            for (int i = 1; i < array.Length; i++)
            {
                array[i] = array[i - 1] ^ encoded[i - 1];
            }

            return array;
        }
    }
}
