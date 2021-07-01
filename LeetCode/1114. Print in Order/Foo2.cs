using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace _1114._Print_in_Order
{
    public class Foo2
    {
        private readonly Semaphore first = new Semaphore(1, 1);
        private readonly Semaphore second = new Semaphore(0, 1);
        private readonly Semaphore third = new Semaphore(0, 1);

        public Foo2()
        {

        }

        public void First(Action printFirst)
        {
            first.WaitOne();
            // printFirst() outputs "first". Do not change or remove this line.
            printFirst();
            second.Release();
        }

        public void Second(Action printSecond)
        {
            second.WaitOne();
            // printSecond() outputs "second". Do not change or remove this line.
            printSecond();
            third.Release();
        }

        public void Third(Action printThird)
        {
            third.WaitOne();
            // printThird() outputs "third". Do not change or remove this line.
            printThird();
            third.Release();
        }
    }
}
