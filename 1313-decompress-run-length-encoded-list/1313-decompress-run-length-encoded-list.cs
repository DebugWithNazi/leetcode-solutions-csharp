public class Solution {
    public int[] DecompressRLElist(int[] nums) {
        var res = new List<int>();
        for(int i = 0; i<nums.Length; i=i+2){
            var freq = nums[i];
            var val = nums[i+1];
            while(freq > 0){
                res.Add(val);
                freq--;
            }
        }
        return res.ToArray();
    }
}