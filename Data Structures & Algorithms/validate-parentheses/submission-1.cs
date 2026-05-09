public class Solution {
    public bool IsValid(string s) {
        Stack<char> stack = new();
        Dictionary<char, char> dict = new() 
        {
            { ')', '(' },
            { '}', '{' },
            { ']', '[' }
        };

        foreach (char c in s)
        {
            if (dict.TryGetValue(c, out char closingBracket)) // closing bracket
            {

                if (stack.Count == 0 || stack.Pop() != closingBracket)
                {
                    return false;
                }
            } 
            else // opening bracket
            {
                stack.Push(c);
            }
        }

        return stack.Count == 0;
    }
}
