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

public class Solution 
{    
    public ListNode MergeKLists(ListNode[] lists) 
    {    
        if(lists.Length == 1)
        {
            return lists[0];
        }
        if(lists.Length < 1)
        {
            return null;            
        }
        var m = lists.Length / 2;       
        ListNode[] leftHalf = lists.Take(m + lists.Length % 2).ToArray();
        ListNode[] rightHalf = lists.Skip(m + lists.Length % 2).ToArray();

        var l = MergeKLists(leftHalf);
        var r = MergeKLists(rightHalf);

        return Merge(l, r);
    }

    private ListNode Merge(ListNode l, ListNode r)
    {
        ListNode head = new ListNode(0);
        var cur = head;       
        while(l != null && r != null)
        {
            if(l.val <= r.val)
            {
                cur.next = new ListNode(l.val); 
                l = l.next;               
            }
            else
            {
                cur.next = new ListNode(r.val);       
                r = r.next;        
            }
            cur = cur.next;
        }
        while(l != null)
        {
            cur.next = new ListNode(l.val);
            l = l.next;
            cur = cur.next;
        }
        while(r != null)
        {
            cur.next = new ListNode(r.val);
            r = r.next;
            cur = cur.next;
        }

        return head.next;
    }
}
