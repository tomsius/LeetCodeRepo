using System;

namespace _21._Merge_Two_Sorted_Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            ListNode l11 = new ListNode(1, new ListNode(2, new ListNode(4)));
            ListNode l21 = new ListNode(1, new ListNode(3, new ListNode(4)));
            Print(MergeTwoLists1(l11, l21));
            Print(MergeTwoLists2(l11, l21));

            ListNode l12 = null;
            ListNode l22 = null;
            Print(MergeTwoLists1(l12, l22));
            Print(MergeTwoLists2(l12, l22));

            ListNode l13 = null;
            ListNode l23 = new ListNode(0);
            Print(MergeTwoLists1(l13, l23));
            Print(MergeTwoLists2(l13, l23));
        }

        public static ListNode MergeTwoLists1(ListNode l1, ListNode l2)
        {
            if (l1 == null && l2 == null)
            {
                return null;
            }
            else if (l1 == null)
            {
                return l2;
            }
            else if (l2 == null)
            {
                return l1;
            }

            ListNode mergedList = null;

            if (l1.val <= l2.val)
            {
                mergedList = new ListNode(l1.val);
                l1 = l1.next;
            }
            else
            {
                mergedList = new ListNode(l2.val);
                l2 = l2.next;
            }

            ListNode root = mergedList;

            while (l1 != null || l2 != null)
            {
                if (l1 == null)
                {
                    mergedList.next = new ListNode(l2.val);
                    l2 = l2.next;
                }
                else if (l2 == null)
                {
                    mergedList.next = new ListNode(l1.val);
                    l1 = l1.next;
                }
                else if (l1.val <= l2.val)
                {
                    mergedList.next = new ListNode(l1.val);
                    l1 = l1.next;
                }
                else
                {
                    mergedList.next = new ListNode(l2.val);
                    l2 = l2.next;
                }

                mergedList = mergedList.next;
            }

            return root;
        }

        public static ListNode MergeTwoLists2(ListNode l1, ListNode l2)
        {
            if (l1 == null)
            {
                return l2;
            }
            else if (l2 == null)
            {
                return l1;
            }

            ListNode root = null;

            if (l1.val <= l2.val)
            {
                root = l1;
                l1 = l1.next;
            }
            else
            {
                root = l2;
                l2 = l2.next;
            }

            ListNode current = root;

            while (l1 != null && l2 != null)
            {
                if (l1.val <= l2.val)
                {
                    current.next = l1;
                    l1 = l1.next;
                }
                else
                {
                    current.next = l2;
                    l2 = l2.next;
                }

                current = current.next;
            }

            current.next = l1 == null ? l2 : l1;

            return root;
        }

        private static void Print(ListNode node)
        {
            while (node != null)
            {
                Console.Write(node.val + " ");
                node = node.next;
            }

            Console.WriteLine();
        }
    }
}
