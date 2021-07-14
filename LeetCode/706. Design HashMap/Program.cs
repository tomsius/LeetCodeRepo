using System;

namespace _706._Design_HashMap
{
    class Program
    {
        static void Main(string[] args)
        {
            MyHashMap1 myHashMap1 = new MyHashMap1();
            myHashMap1.Put(1, 1);
            myHashMap1.Put(2, 2);
            Console.WriteLine(myHashMap1.Get(1));
            Console.WriteLine(myHashMap1.Get(3));
            myHashMap1.Put(2, 1);
            Console.WriteLine(myHashMap1.Get(2));
            myHashMap1.Remove(2);
            Console.WriteLine(myHashMap1.Get(2));
            Console.WriteLine();

            MyHashMap2 myHashMap2 = new MyHashMap2();
            myHashMap2.Put(1, 1);
            myHashMap2.Put(2, 2);
            Console.WriteLine(myHashMap2.Get(1));
            Console.WriteLine(myHashMap2.Get(3));
            myHashMap2.Put(2, 1);
            Console.WriteLine(myHashMap2.Get(2));
            myHashMap2.Remove(2);
            Console.WriteLine(myHashMap2.Get(2));
            Console.WriteLine();
        }
    }
}
