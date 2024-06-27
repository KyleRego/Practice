namespace Challenges;

public class CombinationSum
{
    public static IList<IList<int>> Soln(int[] candidates, int target)
    {
        IList<IList<int>> result = [];

        BackTrack(result, target, [], candidates, 0);

        return result;
    }

    private static void BackTrack(IList<IList<int>> result, int remain, IList<int> comb, int[] candidates, int start)
    {
        if (remain == 0)
        {
            result.Add(new List<int>(comb));
            return;
        }
        else if (remain < 0)
        {
            return;
        }
        for (int i = start; i < candidates.Length; i += 1)
        {
            int cand = candidates[i];
            comb.Add(cand);
            BackTrack(result, remain - cand, comb, candidates, i);
            comb.RemoveAt(comb.Count - 1);
        }
    }
}