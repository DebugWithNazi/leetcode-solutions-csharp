public class Solution {
    public bool RepeatedSubstringPattern(string s) {
        int n = s.Length;

        for(int l = n/2; l>0; l--){
              if(n%l == 0){
                int times = n/l;
                var pattern = s.Substring(0,l);
                StringBuilder sb = new StringBuilder();
                while(times > 0){
                    sb.Append(pattern);
                    times--;
                }
                if(s.Equals(sb.ToString())){
                    return true;
                }
              }
        }
        return false;
    }
}