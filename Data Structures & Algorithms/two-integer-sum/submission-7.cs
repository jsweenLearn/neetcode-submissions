public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        Dictionary<int, int> map = new(); // value: index

        for (int i = 0; i < nums.Length; i++)
        {
            int compliment = target - nums[i]; // diff

            if (map.ContainsKey(compliment))
            {
                return [map[compliment], i];
            }

            map[nums[i]] = i; // value: index
        }
        return [];
    }
}
