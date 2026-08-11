public class MinStack {
    private int[] items;
    private int stackIndex = 0;    

    public MinStack() {
        items = new int[1];
    }
    
    public void Push(int val) {
        if (stackIndex >= items.Length)
        {
            int[] newArray = new int[items.Length * 2];
            for (int i=0; i < items.Length; i++)
            {
                newArray[i] = items[i];
            }  
            items = newArray;          
        }

        items[stackIndex] = val;
        stackIndex++;
    }
    
    public void Pop() {
        items[stackIndex-1] = 0;
        stackIndex--;
    }
    
    public int Top() {
        return items[stackIndex-1];
    }
    
    public int GetMin() {
        int min = int.MaxValue;
        for(int i = 0; i <= stackIndex-1; i++)
        {
            min = Math.Min(min, items[i]);
        }
        return min;
    }
}
