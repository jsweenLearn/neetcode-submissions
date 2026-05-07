public class Solution {
    public int[] ReplaceElements(int[] arr) {
        if (arr.Length == 1) { return new int[] { -1 }; }
        //  f         s
        // [2,4,5,3,1,2]
        // [ , , , ,2,-1]
        int maxRight = -1;

        for (int i = arr.Length - 1; i >= 0; i--)
        {
            int current = arr[i];
            arr[i] = maxRight;
            maxRight = Math.Max(current, arr[i]);
        }

        return arr;
    }
}