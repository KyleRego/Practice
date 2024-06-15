namespace Challenges.Tests;

public class ReverseIntegerTests
{
    [Fact]
    public void Test1()
    {
        Assert.Equal(321, ReverseInteger.Soln(123));
    }

    [Fact]
    public void Test2()
    {
        Assert.Equal(-123, ReverseInteger.Soln(-321));
    }

    [Fact]
    public void Test3()
    {
        Assert.Equal(21, ReverseInteger.Soln(120));
    }
}