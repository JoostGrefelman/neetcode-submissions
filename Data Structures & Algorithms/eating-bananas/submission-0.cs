public class Solution {
    public int MinEatingSpeed(int[] piles, int h) {
        var max = piles.Max();

        var l = 1;
        var r = max;
        var m = (l+r) / 2;
        var smallestResult = -1;
        while(l <= r)
        {
            var success = canEatWithinLimits(piles, m, h);
            Console.WriteLine($"can eat within limits with speed of {m} per hour = {success}");
            if(success)
            {
                smallestResult = m;
                r = m -1;
            }
            else
            {
                l = m + 1;
            }
            m = (l+r) / 2;
        }
        return smallestResult;
    }

    private bool canEatWithinLimits(int[] piles, int speed, int maxHours)
    {
        var eatingHours = 0;
        foreach(var bananas in piles)
        {
            eatingHours += (int) Math.Ceiling((decimal) bananas / (decimal) speed);         
            //Console.WriteLine($"Eating {bananas} bananas in {eatingHours} hours");   
        }
        if(eatingHours <= maxHours)
        {
            return true;
        }
        return false;
    }
}
