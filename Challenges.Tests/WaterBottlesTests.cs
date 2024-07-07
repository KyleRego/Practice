namespace Challenges.Tests;

public class WaterBottlesTests
{
    [Fact]
    public void Test1()
    {
        int result = WaterBottles.NumWaterBottles(15, 4);
        Assert.Equal(19, result);
    }
}