namespace Challenges;

public class LuckyNumbersInMatrixTests
{
    [Fact]
    public void Test1()
    {
        int[][] matrix = [
            [0, 1, 5, 7],
            [3, 4, 9, 5],
            [2, 1, 10, 2]
        ];

        IList<int> result = LuckyNumbersInMatrix.Soln(matrix);

        Assert.Equal(3, result.First());
    }
}