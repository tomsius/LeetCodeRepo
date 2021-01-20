using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _657.Robot_Return_to_Origin
{
    class Program
    {
        static void Main(string[] args)
        {
            string moves1 = "UD";
            Console.WriteLine(JudgeCircle(moves1));
            Console.WriteLine(JudgeCircle2(moves1));

            string moves2 = "LL";
            Console.WriteLine(JudgeCircle(moves2));
            Console.WriteLine(JudgeCircle2(moves2));

            string moves3 = "RRDD";
            Console.WriteLine(JudgeCircle(moves3));
            Console.WriteLine(JudgeCircle2(moves3));

            string moves4 = "LDRRLRUULR";
            Console.WriteLine(JudgeCircle(moves4));
            Console.WriteLine(JudgeCircle2(moves4));

            Console.ReadKey();
        }

        public static bool JudgeCircle(string moves)
        {
            Dictionary<char, int> moveCount = new Dictionary<char, int>(4);
            moveCount.Add('U', 0);
            moveCount.Add('D', 0);
            moveCount.Add('L', 0);
            moveCount.Add('R', 0);

            for (int i = 0; i < moves.Length; i++)
            {
                moveCount[moves[i]]++;
            }

            return moveCount['U'] == moveCount['D'] && moveCount['L'] == moveCount['R'];
        }

        public static bool JudgeCircle2(string moves)
        {
            int horizontal = 0;
            int vertical = 0;

            for (int i = 0; i < moves.Length; i++)
            {
                switch (moves[i])
                {
                    case 'U':
                        vertical++;
                        break;
                    case 'D':
                        vertical--;
                        break;
                    case 'R':
                        horizontal++;
                        break;
                    case 'L':
                        horizontal--;
                        break;
                }
            }

            return horizontal == 0 && vertical == 0;
        }
    }
}
