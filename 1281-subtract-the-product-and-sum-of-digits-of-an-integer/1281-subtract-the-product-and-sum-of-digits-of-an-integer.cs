public class Solution {
    public int SubtractProductAndSum(int n) {
        var nums = new List<int>();
        while(n != 0){
            nums.Add(n%10);
            n = n / 10;
        }
        var prod = 1;
        var sum = 0;
        foreach(var num in nums){
            prod *= num;
            sum += num;
        }
        return prod - sum;
    }
}