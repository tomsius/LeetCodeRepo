using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1678.Goal_Parser_Interpretation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Interpret("G()(al)"));
            Console.WriteLine(Interpret("G()()()()(al)"));
            Console.WriteLine(Interpret("(al)G(al)()()G"));

            Console.ReadKey();
        }

        public static string Interpret(string command)
        {
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < command.Length; i++)
            {
                if (command[i].Equals('G'))
                {
                    sb.Append(command[i]);
                }
                else if (command[i].Equals('(') && command[i + 1].Equals(')'))
                {
                    sb.Append("o");
                    i++;
                }
                else
                {
                    sb.Append("al");
                    i += 3;
                }
            }

            return sb.ToString();
        }
    }
}
