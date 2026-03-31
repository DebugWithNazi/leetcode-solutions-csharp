public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        var dict = new Dictionary<int,int>();

        for(int i = 0; i< nums.Length; i++){
            int complement = target - nums[i];

            if(dict.ContainsKey(complement)){
                return new int[]{ dict[complement], i};
            }
            dict[nums[i]] = i;
        }
        return [-1,-1];

        // -------- another sol -------
        // for(int i = 0; i<nums.Length; i++){
        //     for(int j = i+1; j<nums.Length; j++){
        //         if(nums[i]+nums[j] == target)
        //           return [i,j];
        //     }
        // }
        // return [-1,-1];
    }
}