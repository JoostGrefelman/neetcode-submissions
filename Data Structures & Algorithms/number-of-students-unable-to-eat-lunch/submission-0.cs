public class Solution {
    public int CountStudents(int[] students, int[] sandwiches) {
        Array.Reverse(sandwiches);
        var s = new Stack<int>(sandwiches);
        var q = new Queue<int>(students);
        
        var swCount = 0;
        while(swCount < q.Count && q.Count > 0)
        {
            var preferredSandwich = q.Dequeue();
            if(preferredSandwich == s.Peek())
            {
                s.Pop();
                swCount = 0;
            }
            else
            {
                swCount++;
                q.Enqueue(preferredSandwich);
            }
        }
        return q.Count;
    }
}