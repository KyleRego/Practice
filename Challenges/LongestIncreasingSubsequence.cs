namespace Challenges;

public class LongestIncreasingSubsequence
{
    // Look at this problem again later; it's similar to house robber
    public static int Soln(int[] nums)
    {
        Dictionary<int, int> map = [];

        int result = int.MinValue;

        map[nums.Length - 1] = 1;

        for (int i = nums.Length - 1; i >= 0; i -= 1)
        {
            int thisNum = nums[i];
            int longestForThisI = 1;

            for (int j = i + 1; j < nums.Length; j += 1)
            {
                int numToRight = nums[j];

                if (numToRight > thisNum)
                {
                    int longestForThisIAndJ = 1 + map[j];

                    if (longestForThisIAndJ > longestForThisI)
                    {
                        longestForThisI = longestForThisIAndJ;
                    }
                }
            }

            map[i] = longestForThisI; 

            if (longestForThisI > result)
            {
                result = longestForThisI;
            }
        }

        return result;
    }
}