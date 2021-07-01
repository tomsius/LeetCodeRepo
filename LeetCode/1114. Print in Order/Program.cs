using System;
using System.Threading;

namespace _1114._Print_in_Order
{
    class Program
    {
        static void Main(string[] args)
        {
            Example11();
            Thread.Sleep(100);
            Console.WriteLine();
            Example12();
            Thread.Sleep(100);
            Console.WriteLine();
            Example13();
            Thread.Sleep(100);
            Console.WriteLine();
            Example21();
            Thread.Sleep(100);
            Console.WriteLine();
            Example22();
            Thread.Sleep(100);
            Console.WriteLine();
            Example23();
        }

        private static void Example11()
        {
            Work1 w = new Work1();

            Thread thread1 = new Thread(w.DoWork);
            thread1.Start(1);
            Thread.Sleep(100);

            Thread thread2 = new Thread(w.DoWork);
            thread2.Start(2);
            Thread.Sleep(100);

            Thread thread3 = new Thread(w.DoWork);
            thread3.Start(3);
        }

        private static void Example21()
        {
            Work1 w = new Work1();

            Thread thread1 = new Thread(w.DoWork);
            thread1.Start(1);
            Thread.Sleep(100);

            Thread thread3 = new Thread(w.DoWork);
            thread3.Start(3);
            Thread.Sleep(100);

            Thread thread2 = new Thread(w.DoWork);
            thread2.Start(2);
        }

        private static void Example12()
        {
            Work2 w = new Work2();

            Thread thread1 = new Thread(w.DoWork);
            thread1.Start(1);
            Thread.Sleep(100);

            Thread thread2 = new Thread(w.DoWork);
            thread2.Start(2);
            Thread.Sleep(100);

            Thread thread3 = new Thread(w.DoWork);
            thread3.Start(3);
        }

        private static void Example22()
        {
            Work2 w = new Work2();

            Thread thread1 = new Thread(w.DoWork);
            thread1.Start(1);
            Thread.Sleep(100);

            Thread thread3 = new Thread(w.DoWork);
            thread3.Start(3);
            Thread.Sleep(100);

            Thread thread2 = new Thread(w.DoWork);
            thread2.Start(2);
        }

        private static void Example13()
        {
            Work3 w = new Work3();

            Thread thread1 = new Thread(w.DoWork);
            thread1.Start(1);
            Thread.Sleep(100);

            Thread thread2 = new Thread(w.DoWork);
            thread2.Start(2);
            Thread.Sleep(100);

            Thread thread3 = new Thread(w.DoWork);
            thread3.Start(3);
        }

        private static void Example23()
        {
            Work3 w = new Work3();

            Thread thread1 = new Thread(w.DoWork);
            thread1.Start(1);
            Thread.Sleep(100);

            Thread thread3 = new Thread(w.DoWork);
            thread3.Start(3);
            Thread.Sleep(100);

            Thread thread2 = new Thread(w.DoWork);
            thread2.Start(2);
        }
    }
}
