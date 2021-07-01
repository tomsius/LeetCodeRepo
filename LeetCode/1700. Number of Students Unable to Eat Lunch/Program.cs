using System;
using System.Collections.Generic;

namespace _1700._Number_of_Students_Unable_to_Eat_Lunch
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] students1 = { 1, 1, 0, 0 };
            int[] sandwiches1 = { 0, 1, 0, 1 };
            Console.WriteLine(CountStudents1(students1, sandwiches1));
            students1 = new int[] { 1, 1, 0, 0 };
            sandwiches1 = new int[] { 0, 1, 0, 1 };
            Console.WriteLine(CountStudents2(students1, sandwiches1));

            int[] students2 = { 1, 1, 1, 0, 0, 1 };
            int[] sandwiches2 = { 1, 0, 0, 0, 1, 1 };
            Console.WriteLine(CountStudents1(students2, sandwiches2));
            students2 = new int[] { 1, 1, 1, 0, 0, 1 };
            sandwiches2 = new int[] { 1, 0, 0, 0, 1, 1 };
            Console.WriteLine(CountStudents2(students2, sandwiches2));
        }

        public static int CountStudents1(int[] students, int[] sandwiches)
        {
            Array.Reverse(sandwiches);
            Stack<int> sandwichesStack = new Stack<int>(sandwiches);
            Queue<int> studentsQueue = new Queue<int>(students);
            bool isSandwichTaken = true;

            while (sandwichesStack.Count > 0 && isSandwichTaken)
            {
                isSandwichTaken = false;
                int studentsInQueue = studentsQueue.Count;

                for (int i = 0; i < studentsInQueue; i++)
                {
                    if (studentsQueue.Peek() == sandwichesStack.Peek())
                    {
                        studentsQueue.Dequeue();
                        sandwichesStack.Pop();

                        isSandwichTaken = true;
                    }
                    else
                    {
                        studentsQueue.Enqueue(studentsQueue.Dequeue());
                    }
                }
            }

            return studentsQueue.Count;
        }

        public static int CountStudents2(int[] students, int[] sandwiches)
        {
            Queue<int> studentsQueue = new Queue<int>(students);
            int sandwichIndex = 0;
            int hungryStudents = 0;

            while (hungryStudents != studentsQueue.Count)
            {
                int preferredSandwich = studentsQueue.Dequeue();

                if (preferredSandwich == sandwiches[sandwichIndex])
                {
                    hungryStudents = 0;
                    sandwichIndex++;
                }
                else
                {
                    studentsQueue.Enqueue(preferredSandwich);
                    hungryStudents++;
                }
            }

            return hungryStudents;
        }
    }
}
