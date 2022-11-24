using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8.StringToInteger
{
    internal class Solution
    {
        public int MyAtoi(string s)
        {
            int MAX_VALUE = 2147483647;
            int MIN_VALUE = -2147483648;

            if (s.Length == 0) return 0;

            int res = 0;
            //去前面的空格
            int index = 0;

            while (index < s.Length && s[index] == ' ')
            {
                index++;
            }

            if (index == s.Length)
            {
                return 0;
            }

            int sign = 1;

            if (s[index] == '+')
            {
                index++;
                sign = 1;
            }
            else if (s[index] == '-')
            {
                index++;
                sign = -1;
            }

            while (index < s.Length)
            {
                if (s[index] > '9' || s[index] < '0')
                {
                    break;
                }

                //res后面一定还有一位数
                if (res > MAX_VALUE / 10 || (res == MAX_VALUE / 10 && (s[index] - '0') > MAX_VALUE % 10))
                {
                    return MAX_VALUE;
                }

                if (res < MIN_VALUE / 10 || (res == MIN_VALUE / 10 && (s[index] - '0') > -(MIN_VALUE % 10)))
                {
                    return MIN_VALUE;
                }

                res = res * 10 + (s[index] - '0') * sign;

                Console.WriteLine(res + "=====");

                index++;
            }

            return res;
        }
    }
}
