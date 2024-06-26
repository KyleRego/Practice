namespace Challenges;

public class TwoSum
{
    public static int[] TwoSumSol1(int[] nums, int target)
    {
        for (int i = 0; i < nums.Length; i++)
        {
            int first = nums[i];

            for (int j = i + 1; j < nums.Length; j++)
            {
                int second = nums[j];

                if ((first + second) == target)
                {
                    return [i, j];
                }
            }
        }

        return [];
    }

    public static int[] TwoSumSol2(int[] nums, int target)
    {
        Dictionary<int, int> lookupTable = [];

        for (int i = 0; i < nums.Length; i++)
        {
            int value = nums[i];

            lookupTable[value] = i;
        }

        for (int i = 0; i < nums.Length; i++)
        {
            int complement = target - nums[i];

            if (lookupTable.TryGetValue(complement, out int found) && found != i)
            {
                return [i, found];
            }
        }

        return [];
    }

    public static int[] TwoSumSol3(int[] nums, int target)
    {
        Dictionary<int, int> map = [];

        for (int i = 0; i < nums.Length; i++)
        {
            int value = nums[i];

            int complement = target - value;

            if (map.TryGetValue(complement, out int complementIndex))
            {
                return [i, complementIndex];
            }

            map[value] = i;
        }

        return [];
    }

    public static int[] Again(int[] nums, int target)
    {
        Dictionary<int, int> map = [];

        for (int i = 0; i < nums.Length; i += 1)
        {
            int val = nums[i];

            int complement = target - val;

            if (map.TryGetValue(complement, out int otherIndex))
            {
                return [i, otherIndex];
            }
            else
            {
                map[val] = i;
            }
        }

        return [0, 0];
    }

    public static int[] Again2(int[] nums, int target)
    {
        Dictionary<int, int> map = [];

        for (int i = 0; i < nums.Length; i += 1)
        {
            int num = nums[i];

            int complement = target - num;

            if (map.TryGetValue(complement, out int foundComplementIndex))
            {
                return [i, foundComplementIndex];
            }
            else
            {
                map[num] = i;
            }
        }

        return [-1, -1];
    }
}
