/*
 * @lc app=leetcode id=26 lang=csharp
 *
 * [26] Remove Duplicates from Sorted Array
 */

// @lc code=start
public class Solution {
    public int RemoveDuplicates(int[] nums) {
                if (nums == null||nums.Length==0)
            {
                return 0;
            }
            if (nums.Length == 1)
            {
                return 1;
            }
            var index = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[index] != nums[i])
                {
                    index += 1;
                    nums[index] = nums[i];
                }
            }
            return index+1;
    }
}
// @lc code=end

