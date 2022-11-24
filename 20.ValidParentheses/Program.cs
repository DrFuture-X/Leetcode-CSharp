using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20.ValidParentheses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();
            bool x = solution.IsValid("()[]{}");
            Console.WriteLine(x);
            Console.ReadKey();
        }
    }
}
