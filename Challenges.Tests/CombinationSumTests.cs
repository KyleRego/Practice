namespace Challenges.Tests;

public class CombinationSumTests
{
    [Fact]
    public void Test1()
    {
        int[] candidates = [2,3,6,7];
        int target = 7;

        IList<IList<int>> result = CombinationSum.Soln(candidates, target);

        Assert.Equal(2, result.Count);
    }

    [Fact]
    public void Test1A()
    {
        int[] candidates = [2, 4];
        int target = 4;

        IList<IList<int>> result = CombinationSum.Soln(candidates, target);

        Assert.Equal(2, result.Count);
    }

    [Fact]
    public void Test2()
    {
        int[] candidates = [2,3,5];
        int target = 8;

        IList<IList<int>> result = CombinationSum.Soln(candidates, target);

        Assert.Equal(3, result.Count);
    }

    [Fact]
    public void Test3()
    {
        int[] candidates = [2];
        int target = 1;

        IList<IList<int>> result = CombinationSum.Soln(candidates, target);
        Assert.Equal(0, result.Count);
    }
}