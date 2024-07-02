namespace Challenges.Tests;

public class SqrtTests
{
    [Fact]
    public void Test1()
    {
        Assert.Equal(1, Sqrt.Soln2(1));
        Assert.Equal(1, Sqrt.Soln2(2));
        Assert.Equal(1, Sqrt.Soln2(3));
        Assert.Equal(2, Sqrt.Soln2(4));
        Assert.Equal(4, Sqrt.Soln2(16));
        Assert.Equal(4, Sqrt.Soln2(20));
    }

    [Fact]
    public void Test2()
    {
        Assert.Equal(3, Sqrt.Soln2(13));
        // Assert.Equal(2, Sqrt.Soln2(4));
    }
}