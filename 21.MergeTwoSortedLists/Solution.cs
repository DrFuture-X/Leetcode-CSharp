using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21.MergeTwoSortedLists
{
    public class Solution
    {
        public ListNode MergeTwoLists(ListNode list1, ListNode list2)
        {
            ListNode newList = new ListNode();
            ListNode currentNode = newList;
            while (list1 != null && list2 != null)
            {
                if (list1.val < list2.val)
                {
                    //
                    currentNode.next = list1;
                    //当前指向的节点前移
                    currentNode = currentNode.next;
                    list1 = list1.next;
                }
                else
                {
                    //
                    currentNode.next = list2;
                    //当前指向的节点前移
                    currentNode = currentNode.next;
                    list2 = list2.next;
                }
            }
            if (list1 == null)
            {
                currentNode.next = list2;
            }
            else
            {
                currentNode.next = list1;
            }
            return newList.next;
        }

    }
}
