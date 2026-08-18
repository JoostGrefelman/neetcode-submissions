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
    public bool HasCycle(ListNode head) {
        List<ListNode> nodesPassed = new List<ListNode>();

        while(head != null)
        {
            nodesPassed.Add(head);
            if(nodesPassed.Contains(head.next))
            {
                return true;
            }
            head = head.next;
        }
        return false;
    }
}
