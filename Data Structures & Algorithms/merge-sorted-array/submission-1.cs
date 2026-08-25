public class Solution {
    public void Merge(int[] nums1, int m, int[] nums2, int n) {
        // merge sort
        var tempLeft = new int[m];
        for(int f =0; f< m; f++)
        {
            tempLeft[f] = nums1[f];
        }

        var k = 0;
        var i = 0;
        var j = 0;

        while(i < m && j < n)
        {
            if(tempLeft[i] <= nums2[j])
            {
                nums1[k] = tempLeft[i];
                i++;                
            }
            else
            {
                nums1[k] = nums2[j];
                j++;
            }
            k++;
        }

        while(i < m)
        {
            nums1[k] = tempLeft[i];
            i++;
            k++;
        }

        while (j < n)
        {
            nums1[k] = nums2[j];
            j++;
            k++;
        }

    }
}