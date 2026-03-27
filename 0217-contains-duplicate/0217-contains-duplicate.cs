public class Solution {
    public bool ContainsDuplicate(int[] nums) {
        var unique = new HashSet<int>(nums);
        return unique.Count != nums.Length;
    }
}