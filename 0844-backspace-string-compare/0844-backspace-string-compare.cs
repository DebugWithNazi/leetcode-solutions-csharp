public class Solution {
    public bool BackspaceCompare(string s, string t) {
        var stack1 = new Stack<char>();
        var stack2 = new Stack<char>();

        foreach(var chr in s){
            if(chr == '#' && stack1.Count > 0){
               stack1.Pop();
            }
            else if(Char.IsLetter(chr)){
                stack1.Push(chr);
            }
        }
        foreach(var chr in t){
            if(chr == '#' && stack2.Count > 0){
               stack2.Pop();
            }
            else if(Char.IsLetter(chr)){
                stack2.Push(chr);
            }
        }
        string str1 = new string(stack1.ToArray());
        string str2 = new string(stack2.ToArray());
        return str1 == str2;
}
}