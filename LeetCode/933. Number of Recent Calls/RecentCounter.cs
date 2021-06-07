using System;
using System.Collections.Generic;
using System.Text;

namespace _933._Number_of_Recent_Calls
{
    public class RecentCounter
    {
        private Queue<int> pings;

        public RecentCounter()
        {
            pings = new Queue<int>();
        }

        public int Ping(int t)
        {
            pings.Enqueue(t);

            while (t - 3000 > pings.Peek())
            {
                pings.Dequeue();
            }

            return pings.Count;
        }
    }
}
