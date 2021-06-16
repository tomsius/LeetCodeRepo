using System;
using System.Collections.Generic;

namespace _876._Middle_of_the_Linked_List
{
    class Program
    {
        static void Main(string[] args)
        {
            ListNode head1 = new ListNode(1, new ListNode(2, new ListNode(3, new ListNode(4, new ListNode(5)))));
            Console.WriteLine(MiddleNode(head1).val);

            ListNode head2 = new ListNode(1, new ListNode(2, new ListNode(3, new ListNode(4, new ListNode(5, new ListNode(6))))));
            Console.WriteLine(MiddleNode(head2).val);
        }

        public static ListNode MiddleNode(ListNode head)
        {
            List<ListNode> values = new List<ListNode>();
            int size = 0;

            while (head != null)
            {
                values.Add(head);
                head = head.next;
                size++;
            }

            return values[size / 2];
        }
    }
}
