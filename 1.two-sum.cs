/*
 * @lc app=leetcode id=1 lang=csharp
 *
 * [1] Two Sum
 */
public class Solution {
        public int[] TwoSum(int[] nums, int target)
        {
            int[] result = new int[2];
            for (int i = 0; i < nums.Length - 2; i++)
            {
                bool matched = false;
                var a = target - nums[i];
                for (int j = i + 1; j < nums.Length - 1; j++)
                {
                    if (nums[j] == a)
                    {
                        result[0] = i;
                        result[1] = j;
                        matched = true;
                        break;
                    }
                }
                if (matched)
                {
                    break;
                }
            }
            return result;
        }
}

