public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        for (int i = 0; i < nums.Length; i++)
        {
            for (int j = nums.Length - 1; j > i; j--)
            {
                Console.WriteLine($"nums[{i}]: {nums[i]} + nums[{j}]: {nums[j]}  = {nums[i] + nums[j]}: tgt: {target}");
                if (nums[i] + nums[j] == target)
                {
                    return [i, j];
                }
            }
        }
        return [];
    }
}
