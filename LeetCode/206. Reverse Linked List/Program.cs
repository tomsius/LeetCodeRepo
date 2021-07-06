using System;

namespace _206._Reverse_Linked_List
{
    class Program
    {
        static void Main(string[] args)
        {
            ListNode root1 = new ListNode(1, new ListNode(2, new ListNode(3, new ListNode(4, new ListNode(5)))));
            Print(ReverseList1(root1));
            root1 = new ListNode(1, new ListNode(2, new ListNode(3, new ListNode(4, new ListNode(5)))));
            Print(ReverseList2(root1));

            ListNode root2 = new ListNode(1, new ListNode(2));
            Print(ReverseList1(root2));
            root2 = new ListNode(1, new ListNode(2));
            Print(ReverseList2(root2));

            ListNode root3 = null;
            Print(ReverseList1(root3));
            root3 = null;
            Print(ReverseList2(root3));

            ListNode root4 = new ListNode(1);
            Print(ReverseList1(root1));
            root4 = new ListNode(1);
            Print(ReverseList2(root1));
        }

        public static ListNode ReverseList1(ListNode head)
        {
            if (head == null || head.next == null)
            {
                return head;
            }

            ListNode prev = head;
            ListNode current = head.next;
            ListNode next = current.next;
            prev.next = null;

            while (next != null)
            {
                current.next = prev;
                prev = current;
                current = next;
                next = next.next;
            }

            current.next = prev;

            return current;
        }

        public static ListNode ReverseList2(ListNode head)
        {
            ListNode current = head;

            while (current?.next != null)
            {
                ListNode newHead = current.next;

                current.next = current.next.next;
                newHead.next = head;
                head = newHead;
            }

            return head;
        }

        private static void Print(ListNode listNode)
        {
            ListNode current = listNode;

            while (current != null)
            {
                Console.Write(current.val + " ");
                current = current.next;
            }

            Console.WriteLine();
        }
    }
}
