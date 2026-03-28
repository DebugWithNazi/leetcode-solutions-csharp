public class Solution {
    public void MoveZeroes(int[] nums) {
        var slow = 0;
        
        for(int fast = 0; fast < nums.Length; fast++){
            if(nums[fast] != 0){
                nums[slow] = nums[fast];
                slow++;
            }
        }

        while(slow < nums.Length){
            nums[slow] = 0;
            slow++;
        }
    }
}