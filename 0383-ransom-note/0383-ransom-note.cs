public class Solution {
    public bool CanConstruct(string ransomNote, string magazine) {
         var dict = new Dictionary<char,int>();
         foreach(var chr in ransomNote){
            if(dict.ContainsKey(chr))
            {
                dict[chr] += 1;
            }
            else
            {
                dict[chr] = 1;
            }
        }

        foreach(var chr in magazine)
        {
            if(dict.ContainsKey(chr)){
                dict[chr] -= 1;
                if(dict[chr] == 0)
                {
                    dict.Remove(chr);
                }
            }
        }
        if(dict.Count == 0)
        {
            return true;
        }
        else 
        {
            return false;
        }
    }
}