public class Solution {
    public bool IsValid(string s) {
        Stack<char> stack = new Stack<char>();
        foreach(var ch in s)
        {
            if(ch == '[' || ch == '{' || ch == '(') 
            {
                stack.Push(ch);
                continue;
            }
            
            if(stack.Count == 0) return false;
            if(ch == ']' && stack.Pop() != '[') return false;
            else if(ch == '}' && stack.Pop() != '{') return false;
            else if(ch == ')' && stack.Pop() != '(') return false;            
            
        }

        return stack.Count == 0;
    }
}
