using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1656.Design_an_Ordered_Stream
{
    class Program
    {
        static void Main(string[] args)
        {
            OrderedStream os = new OrderedStream(5);

            Console.WriteLine("[" + string.Join(", ", os.Insert(3, "ccccc")) + "]");
            Console.WriteLine("[" + string.Join(", ", os.Insert(1, "aaaaa")) + "]");
            Console.WriteLine("[" + string.Join(", ", os.Insert(2, "bbbbb")) + "]");
            Console.WriteLine("[" + string.Join(", ", os.Insert(5, "eeeee")) + "]");
            Console.WriteLine("[" + string.Join(", ", os.Insert(4, "ddddd")) + "]");

            Console.ReadKey();
        }
    }
}
