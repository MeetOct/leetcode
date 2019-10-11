/*
 * @lc app=leetcode id=53 lang=csharp
 *
 * [53] Maximum Subarray
 */

// @lc code=start
public class Solution {
    public int MaxSubArray(int[] nums) {
            if (nums == null|| nums.Length==0)
            {
                return 0;
            }
            if (nums.Length == 1)
            {
                return nums[0];
            }
            int maxValue = nums[0];
            var result = nums[0];
            for (int i = 1; i < nums.Length; i++)
            {
                if (maxValue <= 0 && maxValue < nums[i])
                {
                    maxValue = nums[i];
                }
                else
                {
                    maxValue = maxValue + nums[i];
                }
                result = maxValue>result?maxValue:result;
            }
            return result;
    }
}
// @lc code=end

