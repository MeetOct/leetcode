/*
 * @lc app=leetcode id=38 lang=csharp
 *
 * [38] Count and Say
 */

// @lc code=start
public class Solution {
    public string CountAndSay(int n) {
            if(n==1)
            {
                return "1";
            }
            var str = CountAndSay(n - 1);
            if (str.Length == 1)
            {
                return 1.ToString() + str;
            }
            char current= str[0];
            var start = 0;
            var result = new StringBuilder();
            for (int i = 0; i < str.Length; i++)
            {
                if (current != str[i])
                {
                    result.Append((i - start).ToString() + current.ToString());
                    current = str[i];
                    start = i;
                }
            }
            if (start < str.Length)
            {
                result.Append((str.Length - start).ToString() + current.ToString());
            }
            return result.ToString();
    }
}
// @lc code=end

