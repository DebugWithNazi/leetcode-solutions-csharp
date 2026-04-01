public class Solution {
    public string ReorderSpaces(string text) {
        var word = new StringBuilder();
        var spaces = 0;
        var words = new List<string>();
        var final = new StringBuilder();

        foreach(var chr in text){
            if(chr == ' '){
                if(word.Length != 0){
                    words.Add(word.ToString());
                    word.Clear();
                }
                spaces++;
            }
            else{
                word.Append(chr);
            }
        }
        if(word.Length > 0)
        {
            words.Add(word.ToString());
            word.Clear();
        }

        var total = words.Count > 1 ? spaces/ (words.Count-1) : 0;
        var remainder = words.Count > 1 ? spaces % (words.Count-1) : spaces;
        final.Append(words[0]);

        for(int i=1; i<words.Count; i++){
           var count = total;
           while(count > 0){
            final.Append(' ');
            count--;
           }
           final.Append(words[i]);
        }
        while(remainder > 0){
           final.Append(' ');
           remainder--;
        }

        return final.ToString();
           
    }
}