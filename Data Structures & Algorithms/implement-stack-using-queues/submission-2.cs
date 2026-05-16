public class MyStack {
    Queue<int> q1;

    public MyStack() {
        q1 = new();
    }
    
    public void Push(int x) {
        Queue<int> q2 = q1;
        q1 = new();
        q1.Enqueue(x);
        foreach (int num in q2)
        {
            q1.Enqueue(num);
        }
    }
    
    public int Pop() {
        return q1.Dequeue();
    }
    
    public int Top() {
        return q1.Peek();
    }
    
    public bool Empty() {
        return q1.Count == 0;
    }
}

/**
 * Your MyStack object will be instantiated and called as such:
 * MyStack obj = new MyStack();
 * obj.Push(x);
 * int param_2 = obj.Pop();
 * int param_3 = obj.Top();
 * bool param_4 = obj.Empty();
 */