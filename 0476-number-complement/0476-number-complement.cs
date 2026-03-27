public class Solution {
    public int FindComplement(int num) {
        
        var bits = (int)Math.Log2(num) + 1;

        var mask = ( 1 << bits ) - 1;

        return num ^ mask;
    }
}