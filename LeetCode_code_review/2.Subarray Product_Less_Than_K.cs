using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_code_review
{

    //https://leetcode.com/problems/subarray-product-less-than-k/
    // time limited exceded.
    class _2
    {
        public int NumSubarrayProductLessThanK(int[] nums, int k)
        {
            return NumSubarray(nums, k, 0);
        }

        public int NumSubarray(int[] nums, int k, int position)
        {
            if (position == nums.Length)
            {
                return 0;
            }
            int sum = 1;
            int total = 0;
            for (int i = position; i < nums.Length; i++)
            {
                sum *= nums[i];
                total++;
                if (sum >= k)
                {
                    total--;
                    break;
                }
            }
            return total + NumSubarray(nums, k, position + 1);

        }
    }
}
