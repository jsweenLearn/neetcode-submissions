public class Solution {
    public int FindMaxConsecutiveOnes(int[] nums) {
        if (nums.Length == 1) { return nums[0] == 1 ? 1 : 0; } // single element
        else if (nums.Sum() == 0) { return 0; } // all 0's
        
        int maxStreak = 0;
        int currentStreak = 1;

        // [1, 1, 0, 1, 1, 1]
        for (int i = 0; i < nums.Length - 1; i++)
        {
            // if nums[i] == 1
            if (nums[i] == 1)
            {
                // check next number
                if (nums[i + 1] == 1) // streak
                {
                    currentStreak++;
                }
                if (currentStreak > maxStreak)
                {
                    maxStreak = currentStreak;
                }
            }
            // else 0
            else
            {
                currentStreak = 1;
            }
        }

        return maxStreak;
    }
}