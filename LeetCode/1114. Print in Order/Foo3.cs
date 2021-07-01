using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace _1114._Print_in_Order
{
    public class Foo3
    {
        private static AutoResetEvent event1 = new AutoResetEvent(false);
        private static AutoResetEvent event2 = new AutoResetEvent(false);

        public Foo3()
        {

        }

        public void First(Action printFirst)
        {
            // printFirst() outputs "first". Do not change or remove this line.
            printFirst();
            event1.Set();
        }

        public void Second(Action printSecond)
        {
            event1.WaitOne();
            // printSecond() outputs "second". Do not change or remove this line.
            printSecond();
            event2.Set();
        }

        public void Third(Action printThird)
        {
            event2.WaitOne();
            // printThird() outputs "third". Do not change or remove this line.
            printThird();
        }
    }
}
