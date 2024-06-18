namespace Challenges;

public class ReverseInteger
{
    // TODO: Handle overflow
    public static int Soln(int x)
    {
        bool isNegative = false;

        if (x < 10)
        {
            isNegative = true;
            x *= -1;
        }

        int result = 0;

        while (x != 0)
        {
            int remainder = x % 10;

            // This is where overflow needs to be checked
            result = result * 10 + remainder;

            x /= 10;
        }

        return isNegative ? -1 * result : result;
    }
}