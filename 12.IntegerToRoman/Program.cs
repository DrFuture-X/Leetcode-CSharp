using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.IntegerToRoman
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();
            string x = solution.IntToRoman(1994);
            Console.WriteLine(x);
        }
    }
}
