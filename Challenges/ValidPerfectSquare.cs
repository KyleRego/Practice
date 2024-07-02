namespace Challenges;

public class ValidPerfectSquare
{
    public static bool Valid(int x)
    {
        // do a binary search for the square from 0 to x
        // that's not the narrowest range to search
        // but it should be fine

        int left = 0;
        int right = x;
        int pivot;
        long pivotSquared;

        while (left <= right)
        {
            pivot = left + (right - left) / 2;
            pivotSquared = (long) pivot * pivot;

            if (pivotSquared > x)
            {
                right = pivot - 1;
            }
            else if (pivotSquared < x)
            {
                left = pivot + 1;
            }
            else
            {
                return true;
            }
        }

        return false;
    }
}