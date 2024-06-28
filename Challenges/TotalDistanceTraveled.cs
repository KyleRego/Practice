namespace Challenges;

// This is one of the easiest Leetcode problems I have seen
public class TotalDistanceTraveled
{
    public static int DistanceTraveled(int mainTank, int additionalTank)
    {
        // mileage = 10 per tank unit
        // main tank uses 5, then if additional tank has 1, 1 is added to main tank

        int distance = 0;

        while (mainTank >= 5)
        {
            mainTank -= 5;
            distance += 50;

            if (additionalTank >= 1)
            {
                mainTank += 1;
                additionalTank -=1;
            }
        }

        distance += mainTank * 10;

        return distance;
    }
}