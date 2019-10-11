/*
 * @lc app=leetcode id=2 lang=csharp
 *
 * [2] Add Two Numbers
 */
/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */
public class Solution {
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
    {
            var headNode = new ListNode(0);
            var currentNode = headNode;
            var carry = 0;
            var x=l1;
            var y=l2;
            while(x!=null||y!=null)
            {
                int a = (x != null) ? x.val : 0;
                int b = (y != null) ? y.val : 0;
                var value = carry + a + b;
                carry = value / 10;
                currentNode.next = new ListNode(value % 10);
                currentNode = currentNode.next;
                if (x != null) { x = x.next; }
                if (y != null) { y = y.next; }
            }
            if (carry > 0)
            {
                currentNode.next = new ListNode(carry);
            }
            return headNode.next;
    }
}

