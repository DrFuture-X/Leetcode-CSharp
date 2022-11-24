using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9.PalindromeNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();
            bool x = solution.IsPalindrome(123);
            Console.WriteLine(x);
            Console.ReadKey();
        }
    }
}
