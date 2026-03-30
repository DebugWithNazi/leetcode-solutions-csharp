public class Solution {
    public bool IsPalindrome(int x) {
        if(x < 0) return false;
        if(x == 0) return true;
        string reverse = "";
        var original = x;

        while (original > 0)
        {
            reverse += original % 10;
            original = original / 10;
        }
        var result = long.Parse(reverse);
        if (x == result) return true;
        return false;
    }
}