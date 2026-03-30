public class Solution {
    public int ReverseBits(int n) {
        var result = 0;

        for(int i = 0; i< 32; i++){
          result = result << 1; 
          result = ( n & 1 ) | result; 
          n = n >> 1;
        }
        return result;
    }
}