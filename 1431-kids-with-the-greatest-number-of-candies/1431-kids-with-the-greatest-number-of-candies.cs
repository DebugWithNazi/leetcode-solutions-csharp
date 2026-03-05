public class Solution {
    public IList<bool> KidsWithCandies(int[] candies, int extraCandies) {
        
        int max = candies.Max();
        var res = new List<bool>();

        for (int i=0; i<candies.Length; i++){
            if(candies[i] + extraCandies >= max){
                 res.Add(true);
            }
            else{
                res.Add(false);
            }
        }
        return res;
    }
}