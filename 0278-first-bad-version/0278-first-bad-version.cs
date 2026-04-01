/* The isBadVersion API is defined in the parent class VersionControl.
      bool IsBadVersion(int version); */

public class Solution : VersionControl {
    public int FirstBadVersion(int n) {
        int i = n;
        for(i = n; i >0; i--){
            if(IsBadVersion(i) == false){
                return i+1;
            }
        }
        return i+1;
    }
}