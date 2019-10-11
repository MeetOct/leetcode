/*
 * @lc app=leetcode id=20 lang=csharp
 *
 * [20] Valid Parentheses
 */

// @lc code=start
public class Solution {
    public bool IsValid(string s) {
            var stack = new Stack<char>();
            var dic = new Dictionary<char, char>()
            {
                {'(',')' },
                {'{','}' },
                {'[',']' },
            };
            var chars = s.ToList();
            foreach (var item in chars)
            {
                if (!dic.ContainsKey(item) && !dic.ContainsValue(item))
                {
                    return false;
                }
                if (!stack.Any())
                {
                    if (!dic.ContainsKey(item))
                    {
                        return false;
                    }
                    stack.Push(item);
                    continue;
                }
                if (dic.ContainsKey(item))
                {
                    stack.Push(item);
                    continue;
                }
                var top = stack.Pop();
                dic.TryGetValue(top, out char value);
                if (!value.Equals(item))
                {
                    return false;
                }
            }
            return !stack.Any();
    }
}
// @lc code=end

