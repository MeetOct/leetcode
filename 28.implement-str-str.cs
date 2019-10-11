/*
 * @lc app=leetcode id=28 lang=csharp
 *
 * [28] Implement strStr()
 */

// @lc code=start
public class Solution {
    public int StrStr(string haystack, string needle) {
                    if (string.IsNullOrEmpty(needle))
            {
                return 0;
            }
            if (string.IsNullOrEmpty(haystack)|| haystack.Length<needle.Length)
            {
                return -1;
            }
            if (haystack.Equals(needle.Length))
            {
                return 0;
            }
            for (int i = 0; i <= haystack.Length- needle.Length; i++)
            {
                if (haystack.Substring(i, needle.Length).Equals(needle))
                {
                    return i;
                }
            }
            return -1;
    }
}
// @lc code=end

