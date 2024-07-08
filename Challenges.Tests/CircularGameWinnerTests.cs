namespace Challenges.Tests;

public class CircularGameWinnerTests
{
    [Fact]
    public void Test1()
    {
        int n = 5;
        int k = 2;
        int expected = 3;

        int result = CircularGameWinner.FindTheWinner(n, k);
        Assert.Equal(expected, result);

        int a = CircularGameWinner.QueueSoln(n, k);
        Assert.Equal(expected, a);
    }

    [Fact]
    public void Test2()
    {
        int n = 6;
        int k = 5;
        int expected = 1;

        int result = CircularGameWinner.FindTheWinner(n, k);
        Assert.Equal(expected, result);

        int a = CircularGameWinner.QueueSoln(n, k);
        Assert.Equal(expected, a);
    }
}