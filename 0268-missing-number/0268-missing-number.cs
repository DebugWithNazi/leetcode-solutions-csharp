public class Solution {
    public int MissingNumber(int[] nums) {
        var sorted = nums.OrderBy(x => x).ToArray();
        int i;
        for(i = 0; i<nums.Length; i++){
            if(sorted[i]!=i){
                return i;
            }
        }
        return i;
    }
}