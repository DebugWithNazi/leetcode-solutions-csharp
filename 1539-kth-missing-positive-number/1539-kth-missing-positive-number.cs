public class Solution {
    public int FindKthPositive(int[] arr, int k) {
        var missing = 0;
        var num = 1;

        while(true){
            if(!arr.Contains(num)){
                missing++;
                if(missing == k){
                    return num;
                }
            }
            num++;
        }
    }
}