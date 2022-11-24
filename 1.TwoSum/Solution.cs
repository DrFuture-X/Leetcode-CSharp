using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.TwoSum
{
    internal class Solution
    {
        public int[] TwoSum(int[] nums, int target)
        {
            //定义结果，已知结果数组中有两个数
            int[] result = new int[] { 0, 0 };
            for (int i = 0; i < nums.Length - 1; i++)
            {
                //向后遍历
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (nums[i] + nums[j] == target)
                    {
                        result = new int[] { i, j };
                        return result;
                    }
                }
            }
            return result;
        }
    }
}
