public class Solution {
    public int MaximumPopulation(int[][] logs) {
        var max = 0;
        var year = 1950;

        for(int i = 1950; i <= 2050; i++){
            var count = 0;

            foreach(var log in logs){
                if(log[0] <= i && log[1] > i){
                    count++;
                }
            }
            if(count > max){
                max = count;
                year = i;
            }
        }
        return year;
    }
}