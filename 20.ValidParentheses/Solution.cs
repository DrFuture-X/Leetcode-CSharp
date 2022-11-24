using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20.ValidParentheses
{
    internal class Solution
    {
        public bool IsValid(string s)
        {
            Stack<char> stk = new Stack<char>();
            foreach (char c in s)
            {
                if (c == '(')
                {
                    stk.Push(')');
                }
                else if (c == '{')
                {
                    stk.Push('}');
                }
                else if (c == '[')
                {
                    stk.Push(']');
                }
                else if (stk.Count == 0 || c != stk.Pop())
                {
                    return false;
                }
            }
            if (stk.Count == 0)
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
