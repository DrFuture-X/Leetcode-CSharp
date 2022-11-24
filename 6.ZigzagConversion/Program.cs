using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.ZigzagConversion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();
            string x = solution.Convert("PAYPALISHIRING", 3);
            Console.WriteLine(x);


            Console.ReadKey();
        }
    }
}
