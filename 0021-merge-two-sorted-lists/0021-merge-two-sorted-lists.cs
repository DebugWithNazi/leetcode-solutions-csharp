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
    public ListNode MergeTwoLists(ListNode list1, ListNode list2) {
        ListNode head = new ListNode(0);
        var current = head;
        if(list1 == null && list2 == null){
            return list1;
        }
        else if(list1 == null || list2 == null){
            return list1 == null ? list2 : list1;
        }
        // if(list1.val < list2.val){
        //     current.next = new ListNode(list1.val);
        //     current = current.next;
        //     list1 = list1.next;
        // }
        // else{
        //     current.next = new ListNode(list2.val);
        //     current = current.next;
        //     list2 = list2.next;

        // }
        
        while( list1 != null && list2 != null ){
            if(list1.val < list2.val){
                current.next = new ListNode(list1.val);
                current = current.next;
                list1 = list1.next;
            }
            else{
                current.next = new ListNode(list2.val);
                current = current.next;
                list2 = list2.next;
            }
        }
        if(list1 != null){
            current.next = list1;
        }
        else if(list2 != null){
            current.next = list2;
        }

        return head.next;
    }
}