/*
 * @lc app=leetcode id=3 lang=csharp
 *
 * [3] Longest Substring Without Repeating Characters
 */
public class Solution {

    /* 思路：从起始坐标开始，不断将字符串加入字典，遇到重复字符时，确定当前位置所能得到的最大Substring
        更新起始坐标位置为已包含的重复字符坐标，再更新重复字符坐标
        若遇到重复字符时在起始坐标之前，则只更新重复字符坐标，不需要更新其实坐标
     * 1.根据提示选用字典类型来解决问题
     * 2.遍历字符串，依次加入字典，value为字符串中的下标
     * 3.则设置一个起始位置坐标，该位置之前的字符得到的最大Substring长度小于等于当前长度
     * 4.故当前字符存在于字典中时,之前已存在的字符串之前的字符能得到的最大Substring已确定，同时修改当前起始位置坐标，抛弃之前的字符
     */
    public int LengthOfLongestSubstring(string s) {
            if (string.IsNullOrEmpty(s))
            {
                return 0;
            }
            var dic = new Dictionary<char, int>();
            var chars = s.ToCharArray();
            if (chars.Length == 1)
            {
                return 1;
            }
            int index = 0;
            int maxLength = 0;
            for (int i = 0; i < chars.Length; i++)
            {
                var length = 0;
                if (!dic.ContainsKey(chars[i]))
                {
                    dic.Add(chars[i], i);
                    length = i - index + 1;
                    maxLength = length > maxLength ? length : maxLength;
                    continue;
                }
                if (dic[chars[i]] < index)
                {
                    dic[chars[i]] = i;
                    length = i - index + 1;
                    maxLength = length > maxLength ? length : maxLength;
                    continue;
                }
                length = i - index;
                maxLength = length > maxLength ? length : maxLength;
                index = dic[chars[i]] + 1;
                dic[chars[i]] = i;
            }
            return maxLength > 0 ? maxLength : chars.Length;
    }
}

