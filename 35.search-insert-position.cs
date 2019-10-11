/*
 * @lc app=leetcode id=35 lang=csharp
 *
 * [35] Search Insert Position
 */
public class Solution {
    public int SearchInsert(int[] nums, int target) {
            if (nums == null||nums.Length==0)
            {
                return 0;
            }
            if(nums.Length==1)
            {
                return nums[0] >= target ? 0 : 1;
            }
            var start = 0;
            var end = nums.Length - 1;
            while (start< end)
            {
                var mid = start+(end - start) / 2;
                var midValue = nums[mid];
                if (midValue == target)
                {
                    start = mid;
                    break;
                }
                if (midValue > target)
                {
                    end = mid;
                    continue;
                }
                start = mid + 1;
            }
            return nums[start]<target?start+1:start;
    }
}

