public class Solution {
    public int CalPoints(string[] operations) {
        Stack<int> stack = new();

        foreach (string op in operations)
        {
            if (int.TryParse(op, out int num))
            {
                stack.Push(num);
            } 
            else if (op.ToUpper() == "C")
            {
                stack.Pop();
            } 
            else if (op.ToUpper() == "D")
            {
                int val = stack.Peek() * 2;
                stack.Push(val); 
            } 
            else if (op == "+")
            {
                var lastTwo = stack.Take(2).ToArray();
                stack.Push(lastTwo[0] + lastTwo[1]);
            }
        }

        return stack.Sum();
    }
}