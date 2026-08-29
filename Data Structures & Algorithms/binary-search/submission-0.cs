public class Solution {
    public int Search(int[] nums, int target) {
        var l = 0;
        var r = nums.Length -1;
        var m = (r-l) / 2;
        var i = 0;
        while (l <= r)
        {
            i++;
            if(i > 10)
            {
                return -1;
            }
            if(target < nums[m])
            {
                r = m-1;
            }
            else if (target > nums[m])
            {
                l = m + 1;
            }
            else
            {
                return m;
            }
            m = (r-l) / 2 + l;
            Console.WriteLine($"new middle = {m} [{l},{r}]");
        }
        return -1;
    }
}
