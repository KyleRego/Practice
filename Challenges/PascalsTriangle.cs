namespace Challenges;

public class PascalsTriangle
{
    public static IList<IList<int>> Soln(int numRows)
    {
        IList<IList<int>> result = [];

        for (int row = 0; row < numRows; row += 1)
        {
            IList<int> nums = [];

            for (int col = 0; col <= row; col += 1)
            {
                if (col == 0 || col == row)
                {
                    nums.Add(1);
                }
                else
                {
                    nums.Add(result[row - 1][col - 1] + result[row - 1][col]);
                }
            }

            result.Add(nums);
        }

        return result;
    }
}