using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8.StringToInteger
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();

            //int x = solution.MyAtoi("9223372036854775808");
            int x = solution.MyAtoi("2147483654");
            Console.WriteLine(x);

            Console.ReadKey();
        }
    }
}
