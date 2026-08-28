public class Solution {
    public int[][] KClosest(int[][] points, int k) {
        QuickSort(points, 0, points.Length - 1);

        return points.Take(k).ToArray();
    }

    private int[][] QuickSort(int[][] points, int s, int e, int attempts = 0)
    {
        attempts++;


        if(e - s + 1 <= 1)
        {
            //Console.WriteLine($"array small enough ({s}, {e})");
            return points;
        }
        var pivot = points[e];
        var pivotDistance = DistanceToOrigin(pivot[0], pivot[1]); 
        int left = s;

        for (int i = s; i < e; i++)
        {
            if(DistanceToOrigin(points[i][0], points[i][1]) < pivotDistance)
            {
                int[] tmp = points[i];
                points[i] = points[left];
                points[left] = tmp;
                left++;
            }
        }

        points[e] = points[left];
        points[left] = pivot;

        QuickSort(points, s, left-1, attempts);
        QuickSort(points, left+1, e, attempts);
        
        return points;        
    }

    private double DistanceToOrigin(int x, int y)
    {
        var calculatedDistance = Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2));
       // Console.WriteLine("distance: " + calculatedDistance);
        return calculatedDistance;
    }
}
