namespace Challenges.Tests;

public class TotalDistanceTraveledTests
{
    [Fact]
    public void Test1()
    {
        int mainTank = 5;
        int additionalTank = 10;

        Assert.Equal(60, TotalDistanceTraveled.DistanceTraveled(mainTank, additionalTank));
    }

    [Fact]
    public void Test2()
    {
        int mainTank = 1;
        int additionalTank = 2;

        Assert.Equal(10, TotalDistanceTraveled.DistanceTraveled(mainTank, additionalTank));
    }
}