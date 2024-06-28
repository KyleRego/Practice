namespace Challenges.Tests;

public class DivideTwoIntegersTests
{
    [Fact]
    public void Test1()
    {
        int dividend = 10;
        int divisor = 3;

        int result = DivideTwoIntegers.Divide(dividend, divisor);
        Assert.Equal(3, result);
    }

    [Fact]
    public void Test2()
    {
        int dividend = 7;
        int divisor = -3;

        int result = DivideTwoIntegers.Divide(dividend, divisor);
        Assert.Equal(-2, result);
    }

    [Fact]
    public void Test3()
    {
        Assert.Equal(1, DivideTwoIntegers.Divide(1, 1));
    }

    [Fact]
    public void Test4()
    {
        int dividend = -2147483648;
        int divisor = -1;

        int result = DivideTwoIntegers.Divide(dividend, divisor);
        Assert.Equal(2147483647, result);
    }
}