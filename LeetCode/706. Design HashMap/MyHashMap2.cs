using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _706._Design_HashMap
{
    public class MyHashMap2
    {
        private const int MAX_ITEMS = 1000001;
        private int?[] values;

        public MyHashMap2()
        {
            values = new int?[MAX_ITEMS];
        }

        public void Put(int key, int value)
        {
            values[key] = value;
        }

        public int Get(int key)
        {
            return values[key] ?? -1;
        }

        public void Remove(int key)
        {
            values[key] = null;
        }
    }
}
