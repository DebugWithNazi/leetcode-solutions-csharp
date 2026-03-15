public class Solution {
    public string ReverseWords(string s) {
        var words = s.Split(" ");
        var lastWord = words[words.Length-1];
        var str = "";
        for(int i=0; i<words.Length; i++){
            str += Reverse(words[i]);
            if(i != words.Length - 1){
                str += " ";
            }
        }
        return str;
    }

    public string Reverse(string s){
        var str = "";
        var n = s.Length;
        for(int i =n-1; i>=0; i--){
            str += s[i];
        }
        return str;
    }
}