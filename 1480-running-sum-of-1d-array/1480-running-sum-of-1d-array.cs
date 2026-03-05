public class Solution {
    public int[] RunningSum(int[] nums) {
        var res = new List<int>();
        res.Add(nums[0]);
        for(int i=1; i < nums.Length; i++){
            res.Add(res[i-1]+nums[i]);
        }
        return res.ToArray();
    }
}