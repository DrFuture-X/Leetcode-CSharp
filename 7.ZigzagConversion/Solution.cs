using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7.ZigzagConversion
{
    internal class Solution
    {
        public int Reverse(int x)
        {
            if (x == 0) return 0;

            int temp = x;
            long res = 0;

            while (temp != 0)
            {
                res = res * 10 + temp % 10;
                temp = temp / 10;
            }
            if (res < -2147483648 || res > 2147483647)
            {
                return 0;
            }
            return (int)res;
        }
    }
}
