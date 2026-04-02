public class Solution {
    public bool IsStrictlyPalindromic(int n) {
        
        for(int base_b = 2; base_b <= n-2; base_b++)
        {
             var rep = ConvertToBinary(n,base_b);
             var pal =  IsPalindromic(rep);
             if(!pal){
                return false;
             }
        }
        return true;
    }
    public string ConvertToBinary(int n, int base_b){
         var result = "";

         while(n > 0){
            var remainder = n % base_b;
            result = remainder + result;
            n = n / base_b;
        }
        return result;
    }

    public bool IsPalindromic(string str){
        var left = 0; 
        var right = str.Length - 1;

        while(left < right){
            if(str[left] != str[right]){
                return false;
            }
            left++;
            right--;
        }
        return true;
    }
}