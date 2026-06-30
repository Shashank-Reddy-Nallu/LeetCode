public class Solution {
    public int LengthOfLongestSubstring(string s) {
        Dictionary<char, int> charMap = new Dictionary<char,int>();
        int left = 0;
        int maxLength = 0;

        for (int right=0; right<s.Length; right++) {
            char currentChar = s[right];
            if(charMap.ContainsKey(currentChar)) {
                left = Math.Max(left, charMap[currentChar] + 1);
            }

            charMap[currentChar] = right;
            maxLength = Math.Max(maxLength, right - left + 1);
        }

        return maxLength;
    }
}