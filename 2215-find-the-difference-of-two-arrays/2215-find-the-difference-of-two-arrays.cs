public class Solution {
    public IList<IList<int>> FindDifference(int[] nums1, int[] nums2) {
        var result = new List<IList<int>>();

        var set1 = new HashSet<int>(nums1);
        var set2 = new HashSet<int>(nums2);

        var arr1 = set1.Where(n => !set2.Contains(n)).ToList();
        var arr2 = set2.Where(n => !set1.Contains(n)).ToList();

        result.Add(arr1);
        result.Add(arr2);

        return result;
        // ............... another solution ..............
        // var result = new List<IList<int>>(); 
        // nums1 = nums1.Distinct().ToArray();
        // nums2 = nums2.Distinct().ToArray();
        // var arr1 = new List<int>();
        // var arr2 = new List<int>();
        // for(int i = 0; i< nums1.Length; i++){
        //     if(!nums2.Contains(nums1[i])){
        //         arr1.Add(nums1[i]);
        //     }
        // }
        // result.Add(arr1);

        // for(int i = 0; i< nums2.Length; i++){
        //     if(!nums1.Contains(nums2[i])){
        //         arr2.Add(nums2[i]);
        //     }
        // }
        // result.Add(arr2);
        // return result;
    }
}