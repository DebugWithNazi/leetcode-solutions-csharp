public class Solution {
    public bool CheckRecord(string s) {
        var absent = 0;
        var late = 0;

        foreach(var chr in s)
        {
            if(chr == 'A'){
                absent++;
                late = 0;
                if(absent > 1)
                {
                    return false;
                }
            }
            else if(chr == 'L'){
                late++;
                if(late >= 3){
                    return false;
                }
            }
            else{
                late= 0;
            }
        }
        return true;
    }
}