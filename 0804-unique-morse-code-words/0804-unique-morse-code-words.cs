public class Solution {
    public int UniqueMorseRepresentations(string[] words) {
        var res = new HashSet<string>();
        var dict = new Dictionary<char, string>();
            dict['a'] = ".-";
            dict['b'] = "-...";
            dict['c'] = "-.-.";
            dict['d'] = "-..";
            dict['e'] = ".";
            dict['f'] = "..-.";
            dict['g'] = "--.";
            dict['h'] = "....";
            dict['i'] = "..";
            dict['j'] = ".---";
            dict['k'] = "-.-";
            dict['l'] = ".-..";
            dict['m'] = "--";
            dict['n'] = "-.";
            dict['o'] = "---";
            dict['p'] = ".--.";
            dict['q'] = "--.-";
            dict['r'] = ".-.";
            dict['s'] = "...";
            dict['t'] = "-";
            dict['u'] = "..-";
            dict['v'] = "...-";
            dict['w'] = ".--";
            dict['x'] = "-..-";
            dict['y'] = "-.--";
            dict['z'] = "--..";
            

            foreach(var word in words){
                var newMap = "";
                foreach(var chr in word){
                   newMap += dict[chr];
                }
                res.Add(newMap);
            }
            return res.Count();

    }
}