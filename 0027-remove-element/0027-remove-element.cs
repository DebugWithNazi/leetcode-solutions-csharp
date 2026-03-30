public class Solution {
    public int RemoveElement(int[] nums, int val) {
        var slow = 0;
        var count = 0;
        for(int fast = 0; fast < nums.Length; fast++)
        {
            if(nums[fast] != val)
            {
               nums[slow] = nums[fast];
               slow++;
               count++;
            }
        }
        return count;
    }
}