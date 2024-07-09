namespace Challenges.Tests;

public class AverageWaitingTimeTests
{
    [Fact]
    public void Test1()
    {
        int[][] customers = [[5,2],[5,4],[10,3],[20,1]];

        double result = AverageWaitingTime.Soln(customers);

        Assert.Equal(3.25, result);
    }
}