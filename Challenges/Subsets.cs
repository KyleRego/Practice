namespace Challenges;

public class Subsets
{
    public static IList<IList<int>> Soln(int[] nums)
    {
        IList<IList<int>> result = [];

        BackTrack(result, nums, [], 0);

        return result;
    }

    private static void BackTrack(IList<IList<int>> result, int[] nums, List<int> comb, int start)
    {
        result.Add(new List<int>(comb));

        for (int i = start; i < nums.Length; i += 1)
        {
            comb.Add(nums[i]);
            BackTrack(result, nums, comb, i + 1);            
            comb.RemoveAt(comb.Count - 1);
        }
    }
}