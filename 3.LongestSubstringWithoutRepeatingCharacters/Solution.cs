using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.LongestSubstringWithoutRepeatingCharacters
{
    public class Solution
    {
        public int LengthOfLongestSubstring(string s)
        {
            if (s == " ") return 1;
            if (s.Length == 1) return 1;

            char[] strChar = s.ToCharArray();

            string maxStr = "";
            string tempStr = "";

            for (int i = 0; i < strChar.Length; i++)
            {
                char c = strChar[i];

                //判断tempStr是否包含str
                if (tempStr.Contains(c))
                {
                    if (tempStr.Length >= maxStr.Length)
                    {
                        maxStr = tempStr;
                    }
                    //重复字符的位置
                    int index = tempStr.IndexOf(c);
                    tempStr = tempStr.Remove(0, index + 1);
                }
                //将当前字符存入tempStr中
                tempStr += c;
            }
            if (tempStr.Length > maxStr.Length)
            {
                maxStr = tempStr;
            }

            return maxStr.Length;
        }
    }
}
