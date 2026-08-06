public class Solution {
    public int CalPoints(string[] operations) {
        int[] scores = new int[operations.Length];
        int scoreIndex = 0;
        foreach(var op in operations)
        {
            if(int.TryParse(op, out int val))
            {
                scores[scoreIndex] = val;
                scoreIndex++;
            }
            else if (op == "+")
            {
                scores[scoreIndex] = scores[scoreIndex-1] + scores[scoreIndex - 2];
                scoreIndex++;
            }
            else if (op == "C")
            {
                scores[scoreIndex-1] = 0;     
                scoreIndex--;           
            }
            else if (op == "D")
            {
                scores[scoreIndex] = 2 * scores[scoreIndex-1];
                scoreIndex++;
            }

        }
        var total = 0;
        foreach(var score in scores)
        {
            total += score;
        }
        return total;
    }
}