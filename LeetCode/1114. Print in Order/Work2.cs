using System;
using System.Collections.Generic;
using System.Text;

namespace _1114._Print_in_Order
{
    public class Work2
    {
        private Foo2 foo = new Foo2();

        public void DoWork(object data)
        {
            switch ((int)data)
            {
                case 1:
                    foo.First(() => Console.Write("first"));
                    break;
                case 2:
                    foo.Second(() => Console.Write("second"));
                    break;
                case 3:
                    foo.Third(() => Console.Write("third"));
                    break;
                default:
                    break;
            }
        }
    }
}
