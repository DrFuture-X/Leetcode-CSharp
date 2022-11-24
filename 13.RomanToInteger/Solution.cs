using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.RomanToInteger
{
    internal class Solution
    {
        public int RomanToInt(string s)
        {
            int sum = 0;
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == 'M')
                {
                    sum += 1000;
                }
                else
                if (s[i] == 'D')
                {
                    sum += 500;
                }
                else
                if (s[i] == 'C')
                {
                    if (i < s.Length - 1)
                    {
                        if (s[i + 1] == 'M')
                        {
                            sum += 900;
                            i++;
                        }
                        else if (s[i + 1] == 'D')
                        {
                            i++;
                            sum += 400;
                        }
                        else
                        {
                            sum += 100;
                        }
                    }
                    else
                    {
                        sum += 100;
                    }
                }
                else
                if (s[i] == 'L')
                {
                    sum += 50;
                }
                else
                if (s[i] == 'X')
                {
                    if (i < s.Length - 1)
                    {
                        if (s[i + 1] == 'C')
                        {
                            i++;
                            sum += 90;
                        }
                        else if (s[i + 1] == 'L')
                        {
                            i++;
                            sum += 40;
                        }
                        else
                        {
                            sum += 10;
                        }
                    }
                    else
                    {
                        sum += 10;
                    }

                }
                else
                if (s[i] == 'V')
                {
                    sum += 5;
                }
                else
                if (s[i] == 'I')
                {
                    if (i < s.Length - 1)
                    {
                        if (s[i + 1] == 'X')
                        {
                            i++;
                            sum += 9;
                        }
                        else if (s[i + 1] == 'V')
                        {
                            i++;
                            sum += 4;
                        }
                        else
                        {
                            sum += 1;
                        }
                    }
                    else
                    {
                        sum += 1;
                    }

                }
            }
            return sum;
        }
    }
}
