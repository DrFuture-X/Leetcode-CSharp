using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.TwoSum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();
            int[] x = solution.TwoSum(new int[] { 2, 7, 11, 15 }, 9);
            foreach (int t in x)
            {
                Console.Write(t + " ");
            }

            Console.ReadKey();
        }
    }
}
