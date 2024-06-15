namespace Challenges.Tests;

public class AtoiTests
{
    [Fact]
    public void Test1()
    {
        Assert.Equal(45, Atoi.MyAtoi("45"));
    }

    [Fact]
    public void Test2()
    {
        Assert.Equal(-45, Atoi.MyAtoi("-45"));
    }

    [Fact]
    public void Test3()
    {
        Assert.Equal(1, Atoi.MyAtoi("1"));
    }

    [Fact]
    public void Test4()
    {
        Assert.Equal(0, Atoi.MyAtoi("0000"));
    }

    [Fact]
    public void Test5()
    {
        Assert.Equal(45, Atoi.MyAtoi("0045"));
    }

    [Fact]
    public void Test6()
    {
        Assert.Equal(-5, Atoi.MyAtoi("-05"));
    }
}