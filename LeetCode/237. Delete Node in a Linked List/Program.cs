using System;

namespace _237._Delete_Node_in_a_Linked_List
{
    class Program
    {
        static void Main(string[] args)
        {
            ListNode deleteNode1 = new ListNode(5);
            ListNode root1 = new ListNode(4);
            root1.next = deleteNode1;
            root1.next.next = new ListNode(1);
            root1.next.next.next = new ListNode(9);
            DeleteNode(deleteNode1);
            Print(root1);

            ListNode deleteNode2 = new ListNode(1);
            ListNode root2 = new ListNode(4);
            root2.next = new ListNode(5);
            root2.next.next = deleteNode2;
            root2.next.next.next = new ListNode(9);
            DeleteNode(deleteNode2);
            Print(root2);

            ListNode deleteNode3 = new ListNode(3);
            ListNode root3 = new ListNode(1);
            root3.next = new ListNode(2);
            root3.next.next = deleteNode3;
            root3.next.next.next = new ListNode(4);
            DeleteNode(deleteNode3);
            Print(root3);

            ListNode deleteNode4 = new ListNode(0);
            ListNode root4 = deleteNode4;
            root4.next = new ListNode(1);
            DeleteNode(deleteNode4);
            Print(root4);

            ListNode deleteNode5 = new ListNode(-3);
            ListNode root5 = deleteNode5;
            root5.next = new ListNode(5);
            root5.next.next = new ListNode(-99);
            DeleteNode(deleteNode5);
            Print(root5);
        }

        //public static void DeleteNode(ListNode node)
        //{
        //    ListNode nextNode = node.next;
        //    node.val = nextNode.val;
        //    node.next = nextNode.next;
        //}

        public static void DeleteNode(ListNode node)
        {
            node.val = node.next.val;
            node.next = node.next.next;
        }

        private static void Print(ListNode node)
        {
            while (node.next != null)
            {
                Console.Write(node.val + " -> ");
                node = node.next;
            }

            Console.WriteLine(node.val);
        }
    }
}
