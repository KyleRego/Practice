namespace Challenges.Tests;

public class MiddleIndexInArrayTests
{
    [Fact]
    public void Test1()
    {
        int[] nums = [2,3,-1,8,4];
        Assert.Equal(3, MiddleIndexInArray.FindMiddleIndex(nums));
    }

    [Fact]
    public void Test2()
    {
        int[] nums = [1,-1,4];
        Assert.Equal(2, MiddleIndexInArray.FindMiddleIndex(nums));
    }

    [Fact]
    public void Test3()
    {
        int[] nums = [4, 0];
        Assert.Equal(0, MiddleIndexInArray.FindMiddleIndex(nums));
    }
}