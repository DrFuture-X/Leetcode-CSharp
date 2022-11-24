using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.IntegerToRoman
{
    internal class Solution
    {
        public string IntToRoman(int num)
        {
            if (num < 1 || num > 3999) return "";

            string res = "";
            int temp = num;

            int unit = 0;
            int decade = 0;
            int hundred = 0;
            int thousand = 0;

            unit = temp % 10;
            temp = temp / 10;
            decade = temp % 10;
            temp = temp / 10;
            hundred = temp % 10;
            thousand = temp / 10;

            switch (thousand)
            {
                case 0:
                    res += "";
                    break;
                case 1:
                    res += "M";
                    break;
                case 2:
                    res += "MM";
                    break;
                case 3:
                    res += "MMM";
                    break;
            }
            switch (hundred)
            {
                case 0:
                    res += "";
                    break;
                case 1:
                    res += "C";
                    break;
                case 2:
                    res += "CC";
                    break;
                case 3:
                    res += "CCC";
                    break;
                case 4:
                    res += "CD";
                    break;
                case 5:
                    res += "D";
                    break;
                case 6:
                    res += "DC";
                    break;
                case 7:
                    res += "DCC";
                    break;
                case 8:
                    res += "DCCC";
                    break;
                case 9:
                    res += "CM";
                    break;
            }

            switch (decade)
            {
                case 0:
                    res += "";
                    break;
                case 1:
                    res += "X";
                    break;
                case 2:
                    res += "XX";
                    break;
                case 3:
                    res += "XXX";
                    break;
                case 4:
                    res += "XL";
                    break;
                case 5:
                    res += "L";
                    break;
                case 6:
                    res += "LX";
                    break;
                case 7:
                    res += "LXX";
                    break;
                case 8:
                    res += "LXXX";
                    break;
                case 9:
                    res += "XC";
                    break;
            }

            switch (unit)
            {
                case 0:
                    res += "";
                    break;
                case 1:
                    res += "I";
                    break;
                case 2:
                    res += "II";
                    break;
                case 3:
                    res += "III";
                    break;
                case 4:
                    res += "IV";
                    break;
                case 5:
                    res += "V";
                    break;
                case 6:
                    res += "VI";
                    break;
                case 7:
                    res += "VII";
                    break;
                case 8:
                    res += "VIII";
                    break;
                case 9:
                    res += "IX";
                    break;
            }

            return res;
        }
    }
}
