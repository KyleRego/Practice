namespace Challenges;

// Given an integer array nums, return all the triplets
// [nums[i], nums[j], nums[k]]
// such that i != j, i != k, and j != k, and nums[i] + nums[j] + nums[k] == 0.
public class ThreeSum
{
    // Naive O(n^3) approach that checks every possible combination
    public static IList<IList<int>> Soln1(int[] nums)
    {
        bool AlreadyInResult(IList<IList<int>> result, IList<int> needle)
        {
            foreach (IList<int> ints in result)
            {
                if (ints[0] == needle[0] && ints[1] == needle[1] && ints[2] == needle[2])
                {
                    return true;
                }
            }

            return false;
        }

        IList<IList<int>> result = [];

        for (int i = 0; i < nums.Length; i += 1)
        {
            for (int j = i + 1; j < nums.Length; j += 1)
            {
                for (int k = j + 1; k < nums.Length; k += 1)
                {
                    int iVal = nums[i];
                    int jVal = nums[j];
                    int kVal = nums[k];

                    if (iVal + jVal + kVal == 0)
                    {
                        int[] combo = [iVal, jVal, kVal];

                        Array.Sort(combo);

                        if (!AlreadyInResult(result, combo))
                        {
                            result.Add(combo);
                        }
                    }
                }
            }
        }

        return result;
    }

    // TODO: solve again
    public static IList<IList<int>> Soln(int[] nums)
    {
        return [];
    }
}