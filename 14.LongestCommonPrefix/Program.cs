using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.LongestCommonPrefix
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();
            string str = solution.LongestCommonPrefix(new string[] { "flower","flow","flight"});
            Console.WriteLine("flower","flow","flight");
            Console.ReadKey();
        }
    }
}
