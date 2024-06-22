namespace Challenges.Tests;

public class LongestIncreasingSubsequenceTests
{
    [Fact]
    public void Test1()
    {
        int[] nums = nums = [10,9,2,5,3,7,101,18];
        Assert.Equal(4, LongestIncreasingSubsequence.Soln(nums));
    }

    [Fact]
    public void Test2()
    {
        int[] nums = [0,1,0,3,2,3];
        Assert.Equal(4, LongestIncreasingSubsequence.Soln(nums));
    }

    [Fact]
    public void Test3()
    {
        int[] nums = [7,7,7,7,7,7,7];
        Assert.Equal(1, LongestIncreasingSubsequence.Soln(nums));
    }
}