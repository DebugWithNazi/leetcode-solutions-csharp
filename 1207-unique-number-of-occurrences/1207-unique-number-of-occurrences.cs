public class Solution {
    public bool UniqueOccurrences(int[] arr) {
        var dict = new Dictionary<int,int>();
        for(int i =0; i< arr.Length; i++)
        {
           if(dict.ContainsKey(arr[i])){
               dict[arr[i]] +=1;
           }
           else{
             dict[arr[i]] = 1;
           }
        }
        var unique = new HashSet<int>(dict.Values).Count();
        return dict.Values.Count() == unique;
    }
}