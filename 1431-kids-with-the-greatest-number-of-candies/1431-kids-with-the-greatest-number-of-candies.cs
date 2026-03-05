public class Solution {
    public IList<bool> KidsWithCandies(int[] candies, int extraCandies) {
        
        // int max = candies.Max();
        // var res = new List<bool>();

        // for (int i=0; i<candies.Length; i++){
        //     if(candies[i] + extraCandies >= max){
        //          res.Add(true);
        //     }
        //     else{
        //         res.Add(false);
        //     }
        // }
        // return res;
        // ---------------------another solution------------------
        int max = candies.Max();
        return candies.Select(x => x + extraCandies >= max).ToArray();
    }
}