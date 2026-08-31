/** 
 * Forward declaration of guess API.
 * @param  num   your guess
 * @return 	     -1 if num is higher than the picked number
 *			      1 if num is lower than the picked number
 *               otherwise return 0
 * int guess(int num);
 */

public class Solution : GuessGame {
    public int GuessNumber(int n) {
        long l = 1;
        long r = n;
        int m = (int) ((l+r)/2);

        while(l <= r)
        {
            var g = guess((int)m);
            if(g > 0)
            {
                l = m + 1;
            }
            else if(g < 0)
            {
                r = m - 1;
            }
            else
            {
                return m;
            }
            m = (int) ((l+r)/2);
        }

        return -1;
    }
}