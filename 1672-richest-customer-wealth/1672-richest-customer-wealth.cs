public class Solution {
    public int MaximumWealth(int[][] accounts) {
          int count = 0;
          int max = 0;

          for(int i = 0; i < accounts.Length; i++){
            for(int j = 0; j < accounts[i].Length; j++){
                 count += accounts[i][j];
            }
            if(max < count){
                max = count;
            }
            count = 0;
          }

          return max;
    }
}