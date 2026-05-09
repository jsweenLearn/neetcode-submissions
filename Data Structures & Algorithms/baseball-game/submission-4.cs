public class Solution {
    public int CalPoints(string[] operations) {
        Stack<int> stack = new();
        int sum = 0;

        foreach (string op in operations)
        {
            if (int.TryParse(op, out int num))
            {
                stack.Push(num);
                sum += num;
            } 
            else if (op == "C")
            {
                sum -= stack.Pop();
            }
            else if (op == "D")
            {
                int n = stack.Peek() * 2;
                stack.Push(n);
                sum += n;
            }
            else if (op == "+")
            {
                int top = stack.Pop();
                int second = stack.Peek();
                int sumLastTwo = top + second;

                stack.Push(top);
                stack.Push(sumLastTwo);
                sum += sumLastTwo;
            }
        }

        return sum;
    }
}