namespace Challenges.Tests;

public class PalindromeNumberTests
{
    [Fact]
    public void Test1()
    {
        int num = 121;
        Assert.True(PalindromeNumber.Soln(num));
    }

    [Fact]
    public void Test2()
    {
        int num = 123;
        Assert.False(PalindromeNumber.Soln(num));
    }

    [Fact]
    public void Test3()
    {
        int num = -121;
        Assert.False(PalindromeNumber.Soln(num));
    }

    [Fact]
    public void Test4()
    {
        Assert.False(PalindromeNumber.Soln(10));
    }
}