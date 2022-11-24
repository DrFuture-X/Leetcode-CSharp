using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21.MergeTwoSortedLists
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();

            ListNode list4 = new ListNode(5, null);
            ListNode list3 = new ListNode(4, list4);
            ListNode list2 = new ListNode(2, list3);
            ListNode list1 = new ListNode(1, list2);

            ListNode listC = new ListNode(4, null);
            ListNode listB = new ListNode(3, listC);
            ListNode listA = new ListNode(1, listB);

            ListNode listNode = solution.MergeTwoLists(list1, listA);


            Console.WriteLine(listNode.val);
            Console.WriteLine(listNode.next.val);
            Console.WriteLine(listNode.next.next.val);
            Console.WriteLine(listNode.next.next.next.val);
            Console.WriteLine(listNode.next.next.next.next.val);
            Console.WriteLine(listNode.next.next.next.next.next.val);
            Console.WriteLine(listNode.next.next.next.next.next.next.val);
            Console.ReadKey();
        }
    }
}
