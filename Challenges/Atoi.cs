namespace Challenges;

public class Atoi
{
    public static int MyAtoi(string s)
    {
        bool isPositive = true;
        int result = 0;

        int index = 0;

        if (index < s.Length && s[index] == '-')
        {
            isPositive = false;
            index += 1;
        }

        while (index < s.Length && s[index] == '0')
        {
            index += 1;
        }

        while (index < s.Length)
        {
            int digit = s[index] - '0';

            result = result * 10 + digit;

            index += 1;
        }

        return isPositive ? result : -1 * result;
    }
}
