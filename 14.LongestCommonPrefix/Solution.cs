using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.LongestCommonPrefix
{
    internal class Solution
    {
        public string LongestCommonPrefix(string[] strs)
        {
            if (strs == null || strs.Length == 0) return "";
            string s = strs[0];
            for (int i = 0; i < strs.Length; i++)
            {
                int j = 0;
                for (; j < s.Length && j < strs[i].Length; j++)
                {
                    if (s[j] != strs[i][j])
                    {
                        break;
                    }

                }
                s = s.Substring(0, j);
                if (s == "") return "";
            }
            return s;
        }
    }
}
