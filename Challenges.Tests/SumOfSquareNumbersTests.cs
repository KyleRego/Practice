namespace Challenges.Tests;

public class SumOfSquareNumbersTests
{
    [Fact]
    public void Test1()
    {
        Assert.True(SumOfSquareNumbers.JudgeSquareSum(1));
        Assert.True(SumOfSquareNumbers.JudgeSquareSum(2));
        Assert.True(SumOfSquareNumbers.JudgeSquareSum(5));
    }
}