public class Solution {
    public int MajorityElement(int[] nums) {
        var n = nums.Length;
        var majority = n/2;
        var dict = new Dictionary<int,int>();

        for(int i=0; i< nums.Length; i++){
            if(dict.ContainsKey(nums[i])){
                dict[nums[i]] += 1;
                if(dict[nums[i]] > majority){
                    return nums[i];
                }
            }
            else{
                dict[nums[i]] = 1;
                if(dict[nums[i]] > majority){
                    return nums[i];
                }
            }
        }
        return 0;
    }
}