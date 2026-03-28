public class Solution {
    public int SpecialArray(int[] nums) {
       int n = nums.Length;

       for(int x=0; x<=n; x++){
          int count = 0; 

          foreach(var num in nums)
          {
            if(num >= x)
              count++;
          }

          if(count == x) return x;
       }
       return -1;
    }
}