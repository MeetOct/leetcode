/*
 * @lc app=leetcode id=14 lang=csharp
 *
 * [14] Longest Common Prefix
 */
public class Solution {
    public string LongestCommonPrefix(string[] strs) {
                    if(strs==null|| strs.Length==0)
            {
                return "";
            }
            if(strs.Length==1)
            {
                return strs[0];
            }
            var chars =new List<char>();
            bool breaked = false;
            for (int i = 0; i < strs[0].Length; i++)
            {
                var charString=strs[0][i];
                for (int j = 1; j < strs.Length; j++)
                {
                    if(strs[j].Length==i|| strs[j][i] != charString)
                    {
                        breaked = true;
                        break;
                    }
                }
                if(breaked)
                {
                    break;
                }
                chars.Add(charString);
            }
            return new String(chars.ToArray());
    }
}

