public class Solution {
    public double FindMaxAverage(int[] nums, int k) {
        double windowSum = 0; 

        for(int i= 0; i< k; i++){
            windowSum += nums[i];
        }

        double maxSum = windowSum/k;

        for(int i = k; i < nums.Length; i++){
            windowSum += nums[i];
            windowSum -= nums[i - k];
            double avg = windowSum/k;

            maxSum = Math.Max(avg, maxSum);
        }
        return maxSum;
    }
}