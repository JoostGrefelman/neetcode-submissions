public class MyLinkedList {
    ListNode head;
    int index;


    public MyLinkedList() {
        index = -1;
    }
    
    public int Get(int index) {       
       if(head == null) return -1;
       
       var cur = head;
       int i = 0;
       while(i < index)
       {
            if(cur == null) return -1;
            cur = cur.next;
            i++;
       }
       return cur?.val ?? -1;
    }
    
    public void AddAtHead(int val) {             
       head = new ListNode(val, head);
    }
    
    public void AddAtTail(int val) {
       var cur = head;
       while(cur.next != null)
       {
            cur = cur.next;
       }
       cur.next = new ListNode(val);
    }
    
    public void AddAtIndex(int index, int val) {
       if(index == 0) 
       {
           AddAtHead(val);
       }

       var cur = head;
       ListNode prev = null;
       int i = 0;
       while(i < index)
       {
            if(cur == null) return;
            
            prev = cur;
            cur = cur.next;
            i++;
       }    
       prev.next = new ListNode(val,cur);
    }
    
    public void DeleteAtIndex(int index) 
    {
       if(index == 0)
       {
            head = head?.next; 
       }
       var cur = head;
       ListNode prev = null;
       int i = 0;
       while(i < index)
       {
            if(cur.next == null) return;
            
            prev = cur;
            cur = cur.next;
            i++;
       }
       
       prev.next = cur.next;
    }

    


}

public class ListNode {
    public int val;
    public ListNode next;

    public ListNode(int val = 0, ListNode? next = null)
    {
        this.val = val;
        this.next = next;
    }
}

/**
 * Your MyLinkedList object will be instantiated and called as such:
 * MyLinkedList obj = new MyLinkedList();
 * int param_1 = obj.Get(index);
 * obj.AddAtHead(val);
 * obj.AddAtTail(val);
 * obj.AddAtIndex(index,val);
 * obj.DeleteAtIndex(index);
 */