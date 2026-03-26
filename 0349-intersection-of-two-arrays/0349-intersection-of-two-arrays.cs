public class Solution {
    public int[] Intersection(int[] nums1, int[] nums2) {
        var unique1 = nums1.Distinct().ToArray();
        var unique2 = nums2.Distinct().ToArray();

        var result = new List<int>();
        
        foreach(var num1 in unique1){
            if(unique2.Contains(num1)){
                result.Add(num1);
            }
        }
        
        return result.ToArray();
    }
}