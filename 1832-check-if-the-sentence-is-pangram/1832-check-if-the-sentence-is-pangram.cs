public class Solution {
    public bool CheckIfPangram(string sentence) {
        var dict = new Dictionary<char,int>();
        var sum = 0;

        for(int i=0; i<sentence.Length; i++)
        {
            if(!dict.ContainsKey(sentence[i]))
            {
                dict[sentence[i]] = 1;
                sum++;
            }
        }
        if (sum == 26)
           return true;
        else
           return false;
    }
}