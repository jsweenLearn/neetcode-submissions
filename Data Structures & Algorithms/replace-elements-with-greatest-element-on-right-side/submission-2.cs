public class Solution {
    public int[] ReplaceElements(int[] arr) {
        int maxRight = -1;
        int current = 0;

        for (int i = arr.Length - 1; i >= 0; i--)
        {
            current = arr[i];
            arr[i] = maxRight;
            maxRight = Math.Max(current, arr[i]);
        }

        return arr;
    }
}