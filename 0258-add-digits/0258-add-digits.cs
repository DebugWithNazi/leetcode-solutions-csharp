public class Solution {
    public int AddDigits(int num) {
        if (num == 0) return 0;
        return 1 + (num - 1) % 9;
        // ..............another solution.............
        // while(num > 9){
        //     var sum = 0;
                       
        //     while(num > 0){
        //         sum += num % 10;
        //         num = num / 10;
        //     }
           
        //     num = sum;
        // }
        // return num; 
    }
}