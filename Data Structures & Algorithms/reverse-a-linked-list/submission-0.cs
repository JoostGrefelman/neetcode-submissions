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
 // [0, 123] [1, 456] [2, 678] [3, null]
 // [3, 678] [2, 456] [1, 123] [0, null]
 
public class Solution {
    public ListNode ReverseList(ListNode head) {
        ListNode last = null;
        var cur = head;        
        while (cur != null)
        {
             last = new ListNode(cur.val, last);
             cur = cur.next;
        }
        return last;
    }
}
