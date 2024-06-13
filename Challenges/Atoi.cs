namespace Challenges;

// TODO: Consider overflow
public class Atoi
{
    public static int MyAtoi(string s)
    {
        int i = 0;
        bool positive = true;
        int result = 0;

        while (i < s.Length && s[i] == ' ')
        {
            i += 1;
        }

        char signChar = s[i];

        if (signChar == '-')
        {
            positive = false;
            i += 1;
        }
        else if (signChar == '+')
        {
            positive = true;
            i += 1;
        }

        while (i < s.Length && s[i] == '0')
        {
            i += 1;
        }

        while (i < s.Length && char.IsDigit(s[i]))
        {

            result = result * 10 + s[i] - '0';
            i += 1;
        }

        if (positive == false)
        {
            return -1 * result;
        }
        else
        {
            return result;
        }
    }
}
