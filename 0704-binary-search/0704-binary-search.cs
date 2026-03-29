public class Solution {
    public int Search(int[] nums, int target) {
        var first = 0; 
        var last = nums.Length - 1; 

        while(first <= last){
            var mid = first + (last - first) / 2;
            if(nums[mid] == target){
                return mid;
            }
            if(nums[mid] < target){
                first = mid + 1;
            }
            else{
                last = mid - 1; 
            }
            
        }
        return -1;
        

    }
}