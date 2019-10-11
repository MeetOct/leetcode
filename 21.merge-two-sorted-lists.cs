/*
 * @lc app=leetcode id=21 lang=csharp
 *
 * [21] Merge Two Sorted Lists
 */

// @lc code=start
/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */
public class Solution {
    public ListNode MergeTwoLists(ListNode l1, ListNode l2) {
            if (l1 == null)
            {
                return l2;
            }
            if(l2==null)
            {
                return l1;
            }
            ListNode l3;
            if (l1.val > l2.val)
            {
                l3 = l1;
                l1 = l2;
                l2 = l3;
            }
            if (l1.next == null)
            {
                l1.next = l2;
                return l1;
            }
            var a = l1;
            var b = l2;
            while (b!=null)
            {
                if (a.next == null)
                {
                    a.next = b;
                    break;
                }
                while (a.next != null&& a.next.val<=b.val)
                {
                    a = a.next;
                }
                var next = a.next;
                a.next = b;
                b = b.next;
                a = a.next;
                a.next = next;
            }
            return l1;
    }
}
// @lc code=end

