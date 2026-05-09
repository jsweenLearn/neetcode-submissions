public class Solution {
    public bool IsValid(string s) {
        // if (s.Length % 2 != 0) { return false; } // odd length

        Stack<char> stack = new(s.Length / 2); // should only need half of s

        foreach (char c in s)
        {
            switch(c) {
                case '(':
                case '{':
                case '[':
                    stack.Push(c); // push opening bracket
                    break;
                // closing brackets
                case ')':
                    if (stack.Count == 0 || stack.Pop() != '(') { return false; }
                    break;
                case '}':
                    if (stack.Count == 0 || stack.Pop() != '{') { return false; }
                    break;
                case ']':
                    if (stack.Count == 0 || stack.Pop() != '[') { return false; }
                    break;
            }
        }

        return stack.Count == 0;
    }
}
