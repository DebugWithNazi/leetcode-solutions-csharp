public class Solution {
    public int[] GetConcatenation(int[] nums) {
        var n = nums.Length;
        var ans = new int[n*2];
        
        int i = 0;

        for(; i< n; i++){
            ans[i] = nums[i];
        }
        for(int j=0; i<n*2; i++){
            ans[i]= nums[j];
            j++;
        }
        return ans;

    }
}