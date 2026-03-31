/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int val=0, ListNode next=null) {
 *         this.val = val;
 *         this.next = next;
 *     }
 * }
 */
public class Solution {
    public bool IsPalindrome(ListNode head) {
        var sb = new StringBuilder();

        while(head != null){
            sb.Append(head.val);
            head = head.next;
        }
        
        string str = sb.ToString();
        string reversed = new string(str.Reverse().ToArray());
        return str == reversed;
    }
}