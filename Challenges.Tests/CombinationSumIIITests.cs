namespace Challenges.Tests;

public class CombinationSumIIITests
{
    [Fact]
    public void Test1()
    {
        int k = 3;
        int n = 7;

        List<List<int>> expected = [[1,2,4]];

        var result = CombinationSumIII.CombinationSum3(k, n);
        Assert.Single(result);

        var inner = result.First();
        Assert.Equal(3, inner.Count);
    }
}