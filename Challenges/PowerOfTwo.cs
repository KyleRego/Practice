namespace Challenges;

public class PowerOfTwo
{
    // "An integer n is a power of two, if there exists an integer x such that n == 2^x."

    // This solution is obvious; the problem is better to show some bitwise stuff
    public static bool IsPowerOfTwo(int n)
    {
        if (n < 1)
        {
            return false;
        }

        while (n != 1)
        {
            int divideByTwoRemainder = n % 2;

            if (divideByTwoRemainder != 0)
            {
                return false;
            }
            else
            {
                n /= 2;
            }
        }

        return true;
    }
}