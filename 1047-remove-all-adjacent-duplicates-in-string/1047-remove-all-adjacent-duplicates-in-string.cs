public class Solution {
    public string RemoveDuplicates(string s) {
        var stack = new Stack<char>();

        foreach(var chr in s){
            if(stack.Count != 0 && stack.Peek() == chr){
                stack.Pop();
            }
            else if(stack.Count == 0 || stack.Peek() != chr){
                stack.Push(chr);
            }
        }
        return new string(stack.Reverse().ToArray());
    }
}