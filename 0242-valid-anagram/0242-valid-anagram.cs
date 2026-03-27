public class Solution {
    public bool IsAnagram(string s, string t) {
        var dict1 = new Dictionary<char,int>();
        var dict2 = new Dictionary<char,int>();

        for(int i=0; i<s.Length; i++){
            if(dict1.ContainsKey(s[i])){
                dict1[s[i]] += 1;
            }
            else{
                dict1[s[i]] = 1;
            }
        }

        for(int i=0; i<t.Length; i++){
            if(dict2.ContainsKey(t[i])){
                dict2[t[i]] += 1;
            }
            else{
                dict2[t[i]] = 1;
            }
        }

        var isEqual = dict1.OrderBy(x=>x.Key).SequenceEqual(dict2.OrderBy(x=>x.Key));
        return isEqual;
    }
}