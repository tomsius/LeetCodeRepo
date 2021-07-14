using System;

namespace _705._Design_HashSet
{
    class Program
    {
        static void Main(string[] args)
        {
            MyHashSet myHashSet = new MyHashSet();
            myHashSet.Add(1);
            myHashSet.Add(2);
            Console.WriteLine(myHashSet.Contains(2));
            Console.WriteLine(myHashSet.Contains(3));
            myHashSet.Add(2);
            Console.WriteLine(myHashSet.Contains(2));
            myHashSet.Remove(2);
            Console.WriteLine(myHashSet.Contains(2));
        }
    }
}
