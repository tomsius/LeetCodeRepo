using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _706._Design_HashMap
{
    public class MyHashMap1
    {
        private const int MAX_ITEMS = 1000001;
        private int[] values;

        public MyHashMap1()
        {
            values = new int[MAX_ITEMS];
            Array.Fill(values, -1);
        }

        public void Put(int key, int value)
        {
            values[key] = value;
        }

        public int Get(int key)
        {
            return values[key];
        }

        public void Remove(int key)
        {
            values[key] = -1;
        }
    }
}
