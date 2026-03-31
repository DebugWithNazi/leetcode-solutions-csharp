public class Solution {
    public int StrStr(string haystack, string needle) {
        var slow = 0;
        var index = -1;
        for(int fast = 0; fast < haystack.Length; fast++){
            if(haystack[fast] == needle[slow]){
               if(index == -1){ index = fast; }
               slow++;
               if(slow == needle.Length){
                   return index;
               }
            }
            else{
               if(index != -1) fast = index;
               index = -1;
               slow = 0;
            }
        }
        return -1;
    }
}