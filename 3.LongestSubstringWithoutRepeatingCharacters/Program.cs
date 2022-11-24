using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.LongestSubstringWithoutRepeatingCharacters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();

            int x = solution.LengthOfLongestSubstring("aass");
            Console.WriteLine(x);

            Console.ReadKey();
        }
    }
}
