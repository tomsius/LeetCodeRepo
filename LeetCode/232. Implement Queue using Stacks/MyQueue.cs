using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _232._Implement_Queue_using_Stacks
{
    public class MyQueue
    {
        private Stack<int> buffer;
        private Stack<int> queue;

        public MyQueue()
        {
            buffer = new Stack<int>();
            queue = new Stack<int>();
        }

        public void Push(int x)
        {
            buffer.Push(x);
        }

        public int Pop()
        {
            if (queue.Count == 0)
            {
                while (buffer.Count > 0)
                {
                    queue.Push(buffer.Pop());
                }
            }

            return queue.Pop();
        }

        public int Peek()
        {
            if (queue.Count == 0)
            {
                while (buffer.Count > 0)
                {
                    queue.Push(buffer.Pop());
                }
            }

            return queue.Peek();
        }

        public bool Empty()
        {
            return queue.Count == 0 && buffer.Count == 0;
        }
    }

}
