namespace Challenges;

public class PlusOne
{
    public static int[] Soln(int[] digits)
    {
        int toAdd = 1;

        for (int i = digits.Length - 1; i >= 0; i -= 1)
        {
            int newDigit = digits[i] + toAdd;

            if (newDigit >= 10)
            {
                toAdd = 1;
                newDigit -= 10;
            }
            else
            {
                toAdd = 0;
            }

            digits[i] = newDigit;
        }

        if (toAdd == 1)
        {
            int[] newDigits = new int[digits.Length + 1];
            newDigits[0] = 1;
            for (int i = 0; i < digits.Length - 1; i += 1)
            {
                newDigits[i + 1] = digits[i];
            }
            return newDigits;
        }
        else
        {
            return digits;
        }
    }
}