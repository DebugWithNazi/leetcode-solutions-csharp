public class Solution {
    public bool IsValid(string s) {
        var stack = new Stack<int>();

        for(int i =0; i<s.Length; i++){
          if(stack.Count > 0 && stack.Peek() == '(' && s[i] == ')'){
                stack.Pop();
            }
            else if(stack.Count > 0 && stack.Peek() == '{' && s[i] == '}'){
                stack.Pop();
            }
            else if(stack.Count > 0 && stack.Peek() == '[' && s[i] == ']'){
                stack.Pop();
            }
            else{
                stack.Push(s[i]);
            }
        }
    
        return stack.Count() == 0;
    }
}