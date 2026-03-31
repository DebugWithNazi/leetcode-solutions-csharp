public class Solution {
    public int FindClosestNumber(int[] nums) {
        var map = new Dictionary<int,int>();
        var min = int.MaxValue;
        for(int i=0; i< nums.Length;i++){
            var abs = Math.Abs(nums[i]);
            if(abs - 0 < min){
                min = Math.Abs(nums[i]);
                map.Clear();
                map[nums[i]] = min;
            }
            else if(abs == min){
                map[nums[i]] = min; 
            }
        }
        return map.Keys.Max();
    }
}