public class MyStack {
    Queue<int> q;
  
    Queue<int> tempq;
    

    public MyStack() {
        q = new Queue<int>();
         tempq = new Queue<int>();      
    }
    
    public void Push(int x) {  
        tempq.Enqueue(x);
        while(q.Count > 0)
        {
            tempq.Enqueue(q.Dequeue());
        }
        q = tempq;
        tempq = new Queue<int>();
    }
    
    public int Pop() {
        return q.Dequeue();
    }
    
    public int Top() {
        return q.Peek();
    }
    
    public bool Empty() {
        return q.Count == 0;
    }
}

/**
 * Your MyStack object will be instantiated and called as such:
 * MyStack obj = new MyStack();
 * obj.Push(x);
 * int param_2 = obj.Pop();
 * int param_3 = obj.Top();
 * bool param_4 = obj.Empty();
 */