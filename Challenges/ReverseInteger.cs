namespace Challenges;

public class ReverseInteger
{
    // TODO: Look at this again; think more on int.MinValue
    public static int Soln(int x)
    {
        int result = 0;

        while (x != 0)
        {
            int pop = x % 10;

            if ((result * 10 + pop) > int.MaxValue)
            {
                return 0;
            }
            else
            {
                result = result * 10 + pop;
            }

            x /= 10;
        }

        return result;
    }
}