public class Solution {
    public int[] SmallerNumbersThanCurrent(int[] nums) {
        var ans = new int[nums.Length];
        for(int i = 0; i<nums.Length; i++){
            var count = 0;
            for(int j =0; j <nums.Length; j++)
            {
                if(j!=i && nums[j]<nums[i])
                {
                    count++;
                }
            }
            ans[i] = count;
        }
        return ans;
    }
}