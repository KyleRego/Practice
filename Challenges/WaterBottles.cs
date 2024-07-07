namespace Challenges;

public class WaterBottles
{
    // leetcode 1518
    public static int NumWaterBottles(int numBottles, int numExchange)
    {
        int totalDrank = 0;
        int emptyBottles = 0;

        while (numBottles > 0 || emptyBottles >= numExchange)
        {
            if (numBottles > 0)
            {
                totalDrank += numBottles;
                emptyBottles += numBottles;
                numBottles = 0;
            }

            if (emptyBottles >= numExchange)
            {
                numBottles += emptyBottles / numExchange;
                emptyBottles %= numExchange; 
            }
        }

        return totalDrank;
    }
}