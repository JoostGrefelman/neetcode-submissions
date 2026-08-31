public class Solution {
    public bool SearchMatrix(int[][] matrix, int target) {
        var row = FindRowIndexNearTarget(matrix, target);
        Console.WriteLine($"row found: {row}");
        return BinarySearch(matrix[row], target);        
    }

    private int FindRowIndexNearTarget(int[][] arr, int target)
    {
        
        var l = 0;
        var r = arr.Length - 1;
        var m = (r-l+1) / 2;

        while(l <= r)
        {
            var nextVal = m == arr.Length - 1 ? -1 : arr[m+1][0];           
            if (target >= arr[m][0] && (target < nextVal || nextVal == -1))
            {
                return m;
            }
            else if(arr[m][0] < target)
            {
                l = m + 1;                
            }
            else if (arr[m][0] > target)
            {
                r = m - 1;
            }
            m = ((r-l+1) / 2) + l;
        }

        return m;
    }

    private bool BinarySearch(int[] arr, int target)
    {
        var l = 0;
        var r = arr.Length - 1;
        var m = (r-l+1) / 2;

        while(l <= r)
        {
        
            if(arr[m] < target)
            {
                l = m + 1;                
            }
            else if (arr[m] > target)
            {
                r = m - 1;
            }
            else
            {
                return true;
            }
            m = ((r-l+1) / 2) + l;
        }

        return false;
    }
}
