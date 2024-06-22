namespace Challenges.Tests;

public class HappyNumberTests
{
    [Fact]
    public void Test1()
    {
        Assert.True(HappyNumber.IsHappy(19));
    }

    [Fact]
    public void Test2()
    {
        Assert.False(HappyNumber.IsHappy(2));
    }
}