public class Solution {
    public bool IsSubsequence(string s, string t) {
         var slow = 0;

         if(s.Length == 0) return true;
         if(t.Length == 0) return false;
         if(s.Length > t.Length) return false;
         

         for(int fast = 0; fast < t.Length; fast++){
            if(s[slow] == t[fast]){
                slow++;
                if(slow == s.Length){
                    return true;
                }
            }
         }
         return false;
    }
}