public class Solution {
    public int[] PivotArray(int[] nums, int pivot) {
        var left = new List<int>();
        var right = new List<int>();
        var pivots = new List<int>();

        for(int i=0; i< nums.Length; i++){
            if(nums[i] < pivot){
                left.Add(nums[i]);
            }
            else if(nums[i] > pivot){
                right.Add(nums[i]);
            }
            else{
                pivots.Add(nums[i]);
            }
        }

        int[] combined = [..left,..pivots,..right];
        return combined;
    }
}