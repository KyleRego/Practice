namespace Challenges.Tests;

public class PowerOfTwoTests
{
    [Fact]
    public void Test1()
    {
        Assert.False(PowerOfTwo.IsPowerOfTwo(0));
        Assert.False(PowerOfTwo.IsPowerOfTwo(3));
        Assert.False(PowerOfTwo.IsPowerOfTwo(5));
    }

    [Fact]
    public void Test2()
    {
        Assert.True(PowerOfTwo.IsPowerOfTwo(1));
        Assert.True(PowerOfTwo.IsPowerOfTwo(2));
        Assert.True(PowerOfTwo.IsPowerOfTwo(4));
        Assert.True(PowerOfTwo.IsPowerOfTwo(8));
        Assert.True(PowerOfTwo.IsPowerOfTwo(16));
        Assert.True(PowerOfTwo.IsPowerOfTwo(32));
    }
}