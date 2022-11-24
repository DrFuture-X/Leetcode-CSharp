using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9.PalindromeNumber
{
    internal class Solution
    {
        public bool IsPalindrome(int x)
        {
            if (x < 0) return false;

            int n = 0;
            int temp = x;
            while (temp != 0)
            {
                n *= 10;
                int i = temp % 10;
                n += i;
                temp = temp / 10;
            }
            if (x == n)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
