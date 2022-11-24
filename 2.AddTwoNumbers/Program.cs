using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.AddTwoNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();

            //ListNode list4 = new ListNode(6, null);
            ListNode list3 = new ListNode(3, null);
            ListNode list2 = new ListNode(4, list3);
            ListNode list1 = new ListNode(2, list2);

            ListNode listC = new ListNode(4, null);
            ListNode listB = new ListNode(6, listC);
            ListNode listA = new ListNode(5, listB);

            ListNode listNode = solution.MergeTwoLists(list1, listA);


            Console.WriteLine(listNode.val);
            Console.WriteLine(listNode.next.val);
            Console.WriteLine(listNode.next.next.val);
            //Console.WriteLine(listNode.next.next.next.val);
            //Console.WriteLine(listNode.next.next.next.next.val);
            //Console.WriteLine(listNode.next.next.next.next.next.val);
            //Console.WriteLine(listNode.next.next.next.next.next.next.val);
            Console.ReadKey();
        }
    }
}
