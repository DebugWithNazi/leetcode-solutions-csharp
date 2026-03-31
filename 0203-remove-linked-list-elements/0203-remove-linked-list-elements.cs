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
    public ListNode RemoveElements(ListNode head, int val) {

        while (head != null && head.val == val )
        {
            head = head.next;
        }

       if(head == null){
            return head;
        }
        
        ListNode prev = head;
        ListNode current = prev.next;

        while(current != null){
            if(current.val == val){
                prev.next = current.next;
            }
            else{
                prev = current;
            }
            current = current.next;
        }
        return head;
    }
}