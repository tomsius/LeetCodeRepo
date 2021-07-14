using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _705._Design_HashSet
{
    public class MyHashSet
    {
        private const int MAX_ITEMS = 1000001;
        private int[] values;

        public MyHashSet()
        {
            values = new int[MAX_ITEMS];
        }

        public void Add(int key)
        {
            values[key] = 1;
        }

        public void Remove(int key)
        {
            values[key] = 0;
        }

        public bool Contains(int key)
        {
            return values[key] == 1;
        }
    }

}
