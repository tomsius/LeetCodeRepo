using System;
using System.Collections.Generic;
using System.Linq;

namespace _682._Baseball_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] ops1 = { "5", "2", "C", "D", "+" };
            Console.WriteLine(CalPoints1(ops1));
            Console.WriteLine(CalPoints2(ops1));

            string[] ops2 = { "5", "-2", "4", "C", "D", "9", "+", "+" };
            Console.WriteLine(CalPoints1(ops2));
            Console.WriteLine(CalPoints2(ops2));

            string[] ops3 = { "1" };
            Console.WriteLine(CalPoints1(ops3));
            Console.WriteLine(CalPoints2(ops3));
        }

        public static int CalPoints1(string[] ops)
        {
            List<int> record = new List<int>();

            foreach (var operation in ops)
            {
                switch (operation)
                {
                    case "+":
                        int scoreSum = record[record.Count - 1] + record[record.Count - 2];
                        record.Add(scoreSum);
                        break;
                    case "D":
                        int doubledScore = 2 * record[record.Count - 1];
                        record.Add(doubledScore);
                        break;
                    case "C":
                        record.RemoveAt(record.Count - 1);
                        break;
                    default:
                        int newScore = int.Parse(operation);
                        record.Add(newScore);
                        break;
                }
            }

            return record.Sum();
        }

        public static int CalPoints2(string[] ops)
        {
            Stack<int> record = new Stack<int>();

            foreach (var operation in ops)
            {
                switch (operation)
                {
                    case "+":
                        int savedScore = record.Pop();
                        int scoreSum = record.Peek() + savedScore;
                        record.Push(savedScore);
                        record.Push(scoreSum);
                        break;
                    case "D":
                        int doubledScore = 2 * record.Peek();
                        record.Push(doubledScore);
                        break;
                    case "C":
                        record.Pop();
                        break;
                    default:
                        int newScore = int.Parse(operation);
                        record.Push(newScore);
                        break;
                }
            }

            return record.Sum();
        }
    }
}
