public class Solution {
    public int LengthOfLastWord(string s) {
        string[] words = s.Split(' ', StringSplitOptions.RemoveEmptyEntries | StringSplitOptions.TrimEntries);
        return words[words.Length-1].Length;
    }
}