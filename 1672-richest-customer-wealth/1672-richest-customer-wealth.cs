public class Solution {
    public int MaximumWealth(int[][] accounts) {
        //   int count = 0;
        //   int max = int.MinValue;

        //   for(int i = 0; i < accounts.Length; i++){
        //     for(int j = 0; j < accounts[i].Length; j++){
        //          count += accounts[i][j];
        //     }
        //     if(max < count){
        //         max = count;
        //     }
        //     count = 0;
        //   }

        //   return max;
        // ------------ another solution -----------
        int max = int.MinValue;

        for(int i =0; i< accounts.Length; i++){
             int sum = accounts[i].Sum();
             if(max < sum){
                max = sum;
             }
        }
        return max;
    }
}