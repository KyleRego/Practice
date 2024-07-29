namespace Challenges.Tests;

public class CountNumberOfTeamsTests
{
    [Fact]
    public void Test1()
    {
        int[] input = [1, 2, 3, 4];

        Assert.Equal(4, CountNumberOfTeams.Soln(input));
    }
}