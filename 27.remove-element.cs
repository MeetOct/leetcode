/*
 * @lc app=leetcode id=27 lang=csharp
 *
 * [27] Remove Element
 */

// @lc code=start
public class Solution {
    public int RemoveElement(int[] nums, int val) {
            if (nums == null || nums.Length == 0)
            {
                return 0;
            }
            if (nums.Length == 1)
            {
                return nums[0] == val ? 0 : 1;
            }
            var index = 0;
            var latestIndex = nums.Length-1;
            for (int i = 0; i <= latestIndex; i++)
            {
                if (nums[i] == val)
                {
                    index += 1;
                    while (nums[latestIndex]==val&&i< latestIndex)
                    {
                        index += 1;
                        latestIndex -= 1;
                    }
                    nums[i] = nums[latestIndex];
                    latestIndex -= 1;
                }
            }
            return nums.Length - index;
    }
}
// @lc code=end

