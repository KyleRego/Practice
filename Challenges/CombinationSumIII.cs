namespace Challenges;

public class CombinationSumIII
{
    // n = target to sum to
    // k = how many digits in 1-9 are used to sum to n
    public static IList<IList<int>> CombinationSum3(int k, int n)
    {
        IList<IList<int>> result = [];

        BackTrack(result, n, k, [], 1);

        return result;
    }

    private static void BackTrack(IList<IList<int>> result,
                                    int differenceToTarget, int numDigitsLeft,
                                    IList<int> comb, int start)
    {
        if (numDigitsLeft == 0)
        {
            if (differenceToTarget == 0)
            {
                result.Add(new List<int>(comb));
            }
            return;
        }

        if (differenceToTarget <= 0)
        {
            return;
        }

        for (int i = start; i <= 9; i += 1)
        {
            comb.Add(i);
            BackTrack(result, differenceToTarget - i, numDigitsLeft - 1, comb, i + 1);
            comb.RemoveAt(comb.Count - 1);
        }

    }
}