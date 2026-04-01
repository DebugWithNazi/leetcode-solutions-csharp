public class Solution {
    public bool ContainsNearbyDuplicate(int[] nums, int k) {
        
        var set = new HashSet<int>();

        for(int i = 0; i< Math.Min(k,nums.Length) ; i++){
            if(set.Contains(nums[i])){
                return true;
            }
            set.Add(nums[i]);
        }

        for(int i = k; i< nums.Length; i++){
            if(set.Contains(nums[i])){
                return true;
            }
            set.Add(nums[i]);
            set.Remove(nums[i-k]);
        }
        return false;
    }
}