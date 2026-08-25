public class Solution {
    public void Merge(int[] nums1, int m, int[] nums2, int n) {
        //insertion sort
        
        //first make it a single array
        for (int i = m; i < m+n; i++)
        {
            nums1[i] = nums2[i-m];
        }

        for (int i = m; i < nums1.Length; i++)
        {
            int j = i-1;
            while (j >= 0 && nums1[j] > nums1[j+1])
            {
                var temp = nums1[j];
                nums1[j] = nums1[j+1];
                nums1[j+1] = temp;
                j--;
            }
        }
    }
}