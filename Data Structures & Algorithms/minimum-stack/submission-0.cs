public class MinStack {

    private List<int> stack;

    public MinStack() {
        stack = new();
    }
    
    public void Push(int val) {
        stack.Add(val);
    }
    
    public void Pop() {
        if (stack.Count > 0) { stack.RemoveAt(stack.Count - 1); }
    }
    
    public int Top() {
        return stack[^1];
    }
    
    public int GetMin() {
        int min = stack[0];

        for (int i  = 0; i < stack.Count; i++)
        {
            if (stack[i] < min) { min = stack[i]; }
        }

        return min;
    }
}
