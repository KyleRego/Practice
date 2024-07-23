namespace Challenges.Tests;

public class ScoreOfStringTests
{
    [Fact]
    public void Test1()
    {
        Assert.Equal(13, ScoreOfString.Soln("hello"));
        Assert.Equal(50, ScoreOfString.Soln("zaz"));
    }
}