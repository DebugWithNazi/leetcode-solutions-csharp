public class Solution {
    public int SingleNumber(int[] nums) {
        var val = 0;
        foreach(var num in nums){
            val ^= num;
        }
        return val;
    }
}