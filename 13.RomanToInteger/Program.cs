using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.RomanToInteger
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();
            int x = solution.RomanToInt("LVIII");
            Console.WriteLine(x);
            Console.ReadKey();
        }
    }
}
