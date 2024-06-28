namespace Challenges;

public class DivideTwoIntegers
{
    // This one seems easy, but my solution fails when
    // dividend is the - 2^31
    // The editorial says it is one of the hardest mediums
    // if you solve it "properly"
    public static int Divide(int dividend, int divisor)
    {
        bool isNegative = false;

        if (dividend < 0)
        {
            isNegative = !isNegative;
            dividend *= -1;
        }

        if (divisor < 0)
        {
            isNegative = !isNegative;
            divisor *= -1;
        }

        if (divisor > dividend)
        {
            return 0;
        }
        else if (divisor == dividend)
        {
            return isNegative ? -1 : 1;
        }

        int divisorMultiple = 1;

        while (divisorMultiple * divisor < dividend)
        {
            divisorMultiple += 1;
        }

        divisorMultiple -= 1;

        return isNegative ? -1 * divisorMultiple : divisorMultiple;
        
    }
}