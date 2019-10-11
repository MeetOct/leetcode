/*
 * @lc app=leetcode id=13 lang=csharp
 *
 * [13] Roman to Integer
 */
public class Solution {
    public int RomanToInt(string s)
    {
        if (string.IsNullOrWhiteSpace(s))
        {
            return 0;
        }
        var dic = new Dictionary<char,int>()
        {
            { 'I',1},
            { 'V',5},
            { 'X',10},
            { 'L',50},
            { 'C',100},
            { 'D',500},
            { 'M',1000},
        };
        var chars = s.ToCharArray();
        if (chars.Length == 1)
        {
            return dic[chars[0]];
        }
        int result = 0;
        for (int i = 0; i < chars.Length; i++)
        {
            if (i == chars.Length - 1)
            {
                result += dic[chars[i]];
                continue;
            }
            if(dic[chars[i + 1]]>dic[chars[i]])
            {
                result -= dic[chars[i]];
                continue;
            }
            result += dic[chars[i]];
        }
        return result;
    }
}

