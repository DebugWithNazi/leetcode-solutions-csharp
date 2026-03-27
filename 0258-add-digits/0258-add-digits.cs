public class Solution {
    public int AddDigits(int num) {
        
        while(num > 9){
            var digits = new List<int>();
            
            while(num > 0){
                digits.Add(num % 10);
                num = num / 10;
            }
            var sum = 0;
            foreach(var digit in digits){
                sum += digit;
            }
            num = sum;
        }
        return num; 
    }
}