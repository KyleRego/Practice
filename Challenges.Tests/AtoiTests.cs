namespace Challenges.Tests;

public class AtoiTests
{
    [Fact]
    public void Test()
    {
        Assert.Equal(45, Atoi.MyAtoi("45"));
        Assert.Equal(-45, Atoi.MyAtoi("-45"));
        Assert.Equal(1, Atoi.MyAtoi("1"));
        Assert.Equal(0, Atoi.MyAtoi("0000"));
        Assert.Equal(0045, Atoi.MyAtoi("45"));
        Assert.Equal(-5, Atoi.MyAtoi("-05"));
    }
}