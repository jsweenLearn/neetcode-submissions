public class Solution {
    public int[] GetConcatenation(int[] nums) {
        int[] ans = new int[nums.Length * 2];

        Array.Copy(nums, 0, ans, 0,           nums.Length); // arr to copy, start, dest arr, idx strt, how many
        Array.Copy(nums, 0, ans, nums.Length, nums.Length);

        return ans;
    }
}