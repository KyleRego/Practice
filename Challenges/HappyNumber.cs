namespace Challenges;

public class HappyNumber
{
    public static bool IsHappy(int n)
    {
        HashSet<int> previousValues = [];

        int nextValue = SumOfSquaresOfDigits(n);

        while (nextValue != 1)
        {
            if (previousValues.Contains(nextValue))
            {
                return false;
            }
            else
            {
                previousValues.Add(nextValue);
                nextValue = SumOfSquaresOfDigits(nextValue);
            }
        }

        return true;
    }

    private static int SumOfSquaresOfDigits(int n)
    {
        List<int> digits = [];

        while (n != 0)
        {
            digits.Add(n % 10);
            n /= 10;
        }

        int sum = 0;

        foreach (int digit in digits)
        {
            sum += digit * digit;
        }

        return sum;
    }
}