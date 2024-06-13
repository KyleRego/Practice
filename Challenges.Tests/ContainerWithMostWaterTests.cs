namespace Challenges.Tests;

public class ContainerWithMostWaterTests
{
    [Fact]
    public void Test1()
    {
        int[] input = [1,8,6,2,5,4,8,3,7];

        Assert.Equal(49, Water.MaxArea(input));
    }
}