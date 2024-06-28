namespace Challenges.Tests;

public class SubsetsTests
{
    [Fact]
    public void Test1()
    {
        int[] nums = [1,2,3];

        var result = Subsets.Soln(nums);
        Assert.Equal(8, result.Count);
    }
}