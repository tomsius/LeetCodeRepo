using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1290.Convert_Binary_Number_in_a_Linked_List_to_Integer
{
    class Program
    {
        static void Main(string[] args)
        {
            ListNode node1 = new ListNode(1, new ListNode(0, new ListNode(1)));
            Console.WriteLine(GetDecimalValue(node1));

            ListNode node2 = new ListNode(0);
            Console.WriteLine(GetDecimalValue(node2));

            ListNode node3 = new ListNode(1);
            Console.WriteLine(GetDecimalValue(node3));

            ListNode node4 = new ListNode(1, new ListNode(0, new ListNode(0, new ListNode(1, new ListNode(0, new ListNode(0, new ListNode(1, new ListNode(1, new ListNode(1, new ListNode(0, new ListNode(0, new ListNode(0, new ListNode(0, new ListNode(0, new ListNode(0)))))))))))))));
            Console.WriteLine(GetDecimalValue(node4));

            ListNode node5 = new ListNode(0, new ListNode(0));
            Console.WriteLine(GetDecimalValue(node5));

            Console.ReadKey();
        }

        public static int GetDecimalValue(ListNode head)
        {
            int decimalNumber = 0;
            int n = 0;
            ListNode temp = head;

            while (temp != null)
            {
                n++;
                temp = temp.next;
            }

            while (head != null)
            {
                decimalNumber += head.val * (int)Math.Pow(2, --n);
                head = head.next;
            }

            return decimalNumber;
        }
    }
}
