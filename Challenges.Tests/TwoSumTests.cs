namespace Challenges.Tests;

public class TwoSumTests
{
    [Fact]
    public void Test1()
    {
        Assert.Equal([2, 3], TwoSum.TwoSumSol1([0, 1, 3, 4, 2, 2, 63], 7));
        Assert.Equal([2, 3], TwoSum.TwoSumSol2([0, 1, 3, 4, 2, 2, 63], 7));
        Assert.Equal([3, 2], TwoSum.TwoSumSol3([0, 1, 3, 4, 2, 2, 63], 7));
    }

    [Fact]
    public void Test2()
    {
        Assert.Equal([1, 2], TwoSum.TwoSumSol1([3, 2, 4], 6));
        Assert.Equal([1, 2], TwoSum.TwoSumSol2([3, 2, 4], 6));
        Assert.Equal([2, 1], TwoSum.TwoSumSol3([3, 2, 4], 6));
    }

    [Fact]
    public void Test3()
    {
        Assert.Equal([4, 5], TwoSum.TwoSumSol1([7, 97, 8, 9, 11, 2], 13));
        Assert.Equal([4, 5], TwoSum.TwoSumSol2([7, 97, 8, 9, 11, 2], 13));
        Assert.Equal([5, 4], TwoSum.TwoSumSol3([7, 97, 8, 9, 11, 2], 13));
    }
}