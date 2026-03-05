public class Solution {
    public int SubtractProductAndSum(int n) {
        var prod = 1;
        var sum = 0;

        while(n != 0){
            var digit = nums.Add(n%10);
            product *= digit;
            sum += digit;
            n = n / 10;
        }
       
        return prod - sum;
    }
}