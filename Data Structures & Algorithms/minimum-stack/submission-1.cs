public class MinStack {

    private List<int> stack;
    private List<int> minStack;

    public MinStack() {
        stack = new();
        minStack = new();
    }
    
    public void Push(int val) {
        stack.Add(val);

        if (minStack.Count == 0)
        {
            minStack.Add(val);
        }
        else
        {
            int currentMin = minStack[minStack.Count - 1];
            minStack.Add(Math.Min(val, currentMin));
        }
    }
    
    public void Pop() {
        stack.RemoveAt(stack.Count - 1); 
        minStack.RemoveAt(minStack.Count - 1);
    }
    
    public int Top() {
        return stack[^1];
    }
    
    public int GetMin() {
        return minStack[^1];
    }
}
