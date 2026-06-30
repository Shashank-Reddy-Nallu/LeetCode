public class Solution {
    public bool IsValid(string s) {
        var dict = new Dictionary<char, char>{
            {'(', ')'}, {'{', '}'}, {'[', ']'}
        };
        Stack<char> stack = new Stack<char>();

        foreach(char c in s){
            if (dict.TryGetValue(c, out char res)){
                stack.Push(res);
            }
            else {
                if (stack.Count == 0) return false;
                if (stack.Pop() != c) return false;
            }
        }

        return stack.Count == 0;
    }
}