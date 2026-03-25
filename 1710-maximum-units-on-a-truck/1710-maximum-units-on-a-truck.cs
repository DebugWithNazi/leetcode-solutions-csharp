public class Solution {
    public int MaximumUnits(int[][] boxTypes, int truckSize) {
        var sorted = boxTypes.OrderByDescending(x => x[1]).ToList();
        var count = 0;
        var result = 0;
        foreach(var box in sorted){
            if(count + box[0] < truckSize){
                result += box[0] * box[1];
                count += box[0];
            }
            else{
               result += (truckSize-count)*box[1];
               count += truckSize-count;
               break;
            }
        }
        return result;
    }
}