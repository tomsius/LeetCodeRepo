using System;

namespace _232._Implement_Queue_using_Stacks
{
    class Program
    {
        static void Main(string[] args)
        {
            MyQueue queue = new MyQueue();
            queue.Push(1);
            queue.Push(2);
            Console.WriteLine(queue.Peek());
            Console.WriteLine(queue.Pop());
            Console.WriteLine(queue.Empty());
        }
    }
}
