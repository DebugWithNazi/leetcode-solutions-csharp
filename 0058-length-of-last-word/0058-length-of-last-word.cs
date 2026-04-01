public class Solution {
    public int LengthOfLastWord(string s) {
        var str = s.Trim();
        var count = 0;
        for(int i = str.Length-1; i>=0; i--){
            if(str[i] == ' '){
                return count;
            }
            else{
                count++;
            }
        }
        return count;
    }
}