public class Solution {
    public int FindMaxConsecutiveOnes(int[] nums) {
        
        int maxStreak = 0;
        int currentStreak = 0;

        // [1, 1, 0, 1, 1, 1]
        foreach (int num in nums)
        {
            if (num == 1)
            {
                currentStreak++;
                if (currentStreak > maxStreak) { maxStreak = currentStreak; }
            }
            else { currentStreak = 0; }
        }

        return maxStreak;
    }
}