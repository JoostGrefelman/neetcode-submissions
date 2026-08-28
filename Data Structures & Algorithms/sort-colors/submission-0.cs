public class Solution {
    public void SortColors(int[] nums) {
        var counts = new int[3];        
        for(int i =0; i < nums.Length; i++)
        {
            counts[nums[i]]++;
        }

        var k = 0;
        for(int i = 0; i < 3; i++)
        {
            for(int j = 0; j < counts[i]; j++)
            {
                nums[k] = i;
                k++;                
            }
        }
    }
}