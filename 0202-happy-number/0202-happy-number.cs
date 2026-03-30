public class Solution {
    public bool IsHappy(int n) {
        if(n == 1) return true;
        var seen = new HashSet<int>();
        var digit = 0;

        while(n != 1){
           if(seen.Contains(n)) return false;
           seen.Add(n);
           
           while(n > 0){
             digit += (n%10)*(n%10);
             n = n/10;
           }
           
           n = digit;
           digit = 0;
           if(n==1){
            return true;
           }
        }
        return false;
    }
}