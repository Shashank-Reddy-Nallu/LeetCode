public class Solution {
    public IList<IList<string>> GroupAnagrams(string[] strs) {
        var res = new Dictionary<string, List<string>>();

        foreach(var word in strs){
            char[] charCount = new char[26];
            foreach(char c in word){
                charCount[c - 'a']++;
            }

            var key = string.Join("#", charCount);
            if(!res.ContainsKey(key)){
                res[key] = new List<string>();
            }

            res[key].Add(word);
        }

        return new List<IList<string>>(res.Values);
    }
}