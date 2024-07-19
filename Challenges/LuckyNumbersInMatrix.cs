namespace Challenges;

public class LuckyNumbersInMatrix
{
    public static IList<int> Soln(int[][] matrix)
    {
        int rows = matrix.Length;
        if (rows == 0) return [];

        IList<int> result = [];
        int cols = matrix[0].Length;

        Dictionary<int, int> columnMaximums = [];
        // it would be better to find the rowMinimums during this too
        for (int i = 0; i < cols; i += 1)
        {
            for (int j = 0; j < rows; j += 1)
            {
                int val = matrix[j][i];

                if (columnMaximums.TryGetValue(i, out int curMax))
                {
                    if (val > curMax)
                    {
                        columnMaximums[i] = val;
                    }
                }
                else
                {
                    columnMaximums[i] = val;
                }
            }
        }

        for (int i = 0; i < rows; i += 1)
        {
            int[] row = matrix[i];

            int rowMinimum = int.MaxValue;
            int rowMinimumCol = -1;

            for (int j = 0; j < cols; j += 1)
            {
                int val = row[j];

                if (val < rowMinimum)
                {
                    rowMinimum = val;
                    rowMinimumCol = j;
                }
            }
            // a place to get tripped up on the comparison operator
            if (rowMinimum >= columnMaximums[rowMinimumCol])
            {
                result.Add(rowMinimum);
            }
        }

        return result;
    }
}