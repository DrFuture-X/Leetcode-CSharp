using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.AddTwoNumbers
{
    public class Solution
    {
        public ListNode MergeTwoLists(ListNode l1, ListNode l2)
        {
            ListNode addList = new ListNode();
            ListNode currentNode = addList;

            //进位
            int carry = 0;

            while (l1 != null || l2 != null)
            {
                int sum = carry;
                if (l1 != null)
                {
                    sum += l1.val;
                    l1 = l1.next;
                }
                if (l2 != null)
                {
                    sum += l2.val;
                    l2 = l2.next;
                }

                carry = sum / 10;
                currentNode.next = new ListNode(sum % 10);
                currentNode = currentNode.next;
            }

            //最后节点的数据
            if (carry > 0)
            {
                currentNode.next = new ListNode(carry);
            }
            return addList.next;
        }
    }
}
