namespace Challenges;

public class CombinationSum
{
    // This works if target is in candidates, at least
    // one test is passing...
    // TODO: Continue on this problem
    public static IList<IList<int>> Soln(int[] candidates, int target)
    {
        Array.Sort(candidates);

        Dictionary<int, IList<IList<int>>> map = SetupMap(candidates, target);

        return map[target];
    }

    private static Dictionary<int, IList<IList<int>>> SetupMap(int[] candidates, int target)
    {
        Dictionary<int, IList<IList<int>>> map = [];

        for (int i = 0; i < candidates.Length; i += 1)
        {
            int candidate = candidates[i];

            if (candidate > target)
            {
                break;
            }

            map[candidate] = [[candidate]];

            for (int j = 0; j < i; j += 1)
            {
                int thisNum = candidates[j];
                int howMany = 1;

                while (howMany * thisNum < candidate)
                {
                    int desiredComplement = candidate - thisNum * howMany;

                    if (map.TryGetValue(desiredComplement, out IList<IList<int>>? outd))
                    {
                        foreach (IList<int> asdf in outd)
                        {
                            IList<int> a = [];
                            for (int f = 0; f < howMany; f += 1)
                            {
                                a.Add(thisNum);
                            }

                            foreach (int b in asdf)
                            {
                                a.Add(b);
                            }
                            map[candidate].Add(a);
                        }
                    }
                    howMany += 1;
                }
                
            }
        }

        return map;
    }
}