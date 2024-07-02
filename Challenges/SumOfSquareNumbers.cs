namespace Challenges;

public class SumOfSquareNumbers
{
    // this solution is accepted but the time complexity is terrible
    // 
    public static bool JudgeSquareSum(int c)
    {
        List<long> seen = [];

        for (int i = 0; i <= c; i += 1)
        {
            long iSquared = (long) i * i;

            if (iSquared > c)
            {
                break;
            }
            else
            {
                long neededComplement = c - iSquared;

                if (neededComplement == iSquared)
                {
                    return true;
                }

                if (seen.Contains(neededComplement))
                {
                    return true;
                }

                seen.Add(iSquared);
            }
        }

        return false;
    }
}