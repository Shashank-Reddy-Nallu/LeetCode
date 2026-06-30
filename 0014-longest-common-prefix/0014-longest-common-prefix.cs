public class Solution {
    public string LongestCommonPrefix(string[] strs) {
        if (strs is null || strs.Length == 0) return string.Empty;
        string smallStr = strs[0];
        for (int i=0; i<strs.Length; i++){
            if(strs[i].Length < smallStr.Length) smallStr = strs[i];
        }

        for(int i=0; i<smallStr.Length; i++){
            foreach(string item in strs){
                if(item[i] != smallStr[i]){
                    return smallStr.Substring(0, i);
                }
            }
        }

        return smallStr;
    }
}