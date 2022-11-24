using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.ZigzagConversion
{
    public class Solution
    {
        public string Convert(string s, int numRows)
        {
            if (numRows == 1) return s;

            //是否使从上往下
            bool isDown = true;
            //当前的行号
            int curRow = 0;
            //定义行数数量的字符串
            string[] rowStr = new string[numRows];

            for (int i = 0; i < s.Length; i++)
            {
                rowStr[curRow] += s[i];
                if (isDown == true)
                {
                    curRow += 1;
                }
                else
                {
                    curRow -= 1;
                }

                if (curRow == numRows - 1)
                {
                    isDown = false;
                }
                if (curRow == 0)
                {
                    isDown = true;
                }
            }

            string result = "";
            foreach (string str in rowStr)
            {
                result += str;
            }
            return result;
        }
    }
}

