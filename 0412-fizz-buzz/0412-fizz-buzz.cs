public class Solution {
    public IList<string> FizzBuzz(int n) {
        var str = new List<string>();
        for(int i = 1; i<=n; i++){
           if(i % 3 == 0 && i % 5 == 0){
            str.Add("FizzBuzz");
           }
           else if(i % 3 == 0){
            str.Add("Fizz");
           }
           else if(i % 5 == 0){
             str.Add("Buzz");
           }
           else{
            str.Add($"{i}");
           }
        }
        return str;
    }
}