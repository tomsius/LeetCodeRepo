using System;

namespace _933._Number_of_Recent_Calls
{
    class Program
    {
        static void Main(string[] args)
        {
            RecentCounter obj = new RecentCounter();
            Console.WriteLine(obj.Ping(1));
            Console.WriteLine(obj.Ping(100));
            Console.WriteLine(obj.Ping(3001));
            Console.WriteLine(obj.Ping(3002));
        }
    }
}
