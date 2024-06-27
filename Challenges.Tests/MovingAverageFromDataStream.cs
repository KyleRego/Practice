namespace Challenges.Tests;

public class MovingAverageTests
{
    [Fact]
    public void Test1()
    {
        var ma = new MovingAverage(3);

        Assert.Equal(1, ma.Next(1));
        Assert.Equal(5.5, ma.Next(10));
        ma.Next(3);
        Assert.Equal(6.0, ma.Next(5));
    }
}