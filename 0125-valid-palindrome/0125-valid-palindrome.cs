public class Solution {
    public bool IsPalindrome(string s) {
        int i = 0;
        int ls = s.Length;
        int j = ls-1;

        while (i<j){
            while(i<ls && !char.IsLetterOrDigit(s[i])) i++;
            while(j>=0 && !char.IsLetterOrDigit(s[j])) j--;
            if (i>ls || j<0) return true;
            if (char.ToLower(s[i]) != char.ToLower(s[j])) return false;
            
            i++;
            j--;
        }

        return true;
    }
}