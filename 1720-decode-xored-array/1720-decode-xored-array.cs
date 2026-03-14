public class Solution {
    public int[] Decode(int[] encoded, int first) {
        var n = encoded.Length;
        var res = new int[n + 1];
        res[0] = first;

        for( int i = 0; i<n; i++ ){
            res[i+1] = res[i] ^ encoded[i];
        }
        return res;
    }
}