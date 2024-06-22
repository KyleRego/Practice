namespace Challenges;

public class AddDigits
{
    public static int Add(int num)
    {
        if (LengthOfNum(num) == 1) return num;

        do
        {
            num = AddDigitsTogether(num);
        }
        while (LengthOfNum(num) != 1);

        return num;
    }

    private static int LengthOfNum(int num)
    {
        if (num == 0) return 1;

        List<int> digits = [];

        while (num != 0)
        {
            digits.Add(num % 10);
            num /= 10;
        }

        return digits.Count;
    }

    private static int AddDigitsTogether(int num)
    {
        List<int> digits = [];

        while (num != 0)
        {
            digits.Add(num % 10);
            num /= 10;
        }

        int sum = 0;
        foreach (int digit in digits)
        {
            sum += digit;
        }
        return sum;
    }
}