public class Solution {
    public int RemoveDuplicates(int[] nums) {
        var slow = 0;
        var count = 1;

        for(int fast = 0; fast < nums.Length; fast++){
            if(nums[fast] != nums[slow]){
                slow++;
                nums[slow] = nums[fast];
                count++;
            }
        }
        return count;
    }
}