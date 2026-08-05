public class Solution {
    public int FindMaxConsecutiveOnes(int[] nums) {
        int maxConsecutiveOnes = 0;
        int currentStreak = 0;
        foreach(int num in nums)
        {
            if(num == 1)
            {
                currentStreak++;
            }
            else
            {
                maxConsecutiveOnes = Math.Max(maxConsecutiveOnes, currentStreak);
                currentStreak = 0;
            }
        }
        maxConsecutiveOnes = Math.Max(maxConsecutiveOnes, currentStreak);

        return maxConsecutiveOnes;
    }
}