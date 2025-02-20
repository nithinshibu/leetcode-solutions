using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeSolutions.Top_50_Hacker_Rank
{
    internal class Q01_TwoSum
    {
        public int[] TwoSum(int[] nums, int target)
        {
            Dictionary<int, int> map = new Dictionary<int, int>();

            for (int i = 0; i < nums.Length; i++)
            {
                int complement = target - nums[i];

                if (map.ContainsKey(complement))
                {
                    return new int[] { map[complement], i };

                }

                if (!map.ContainsKey(nums[i]))
                {
                    map.Add(nums[i], i);
                }
            }

            return new int[0];
        }
    }
}
