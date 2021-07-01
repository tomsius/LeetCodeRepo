using System;
using System.Collections.Generic;
using System.Text;

namespace _1114._Print_in_Order
{
    public class Foo1
    {
        private int action = 1;

        public Foo1()
        {

        }

        public void First(Action printFirst)
        {
            action = 2;

            // printFirst() outputs "first". Do not change or remove this line.
            printFirst();
        }

        public void Second(Action printSecond)
        {
            while (action != 2)
            {
                continue;
            }

            action = 3;

            // printSecond() outputs "second". Do not change or remove this line.
            printSecond();
        }

        public void Third(Action printThird)
        {
            while (action != 3)
            {
                continue;
            }

            // printThird() outputs "third". Do not change or remove this line.
            printThird();
        }
    }
}
