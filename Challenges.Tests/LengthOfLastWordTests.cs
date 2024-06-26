namespace Challenges.Tests;

public class LengthOfLastWordTests
{
    [Fact]
    public void Test1()
    {
        int result = LengthOfLastWord.Soln("   fly me   to   the moon  ");
        Assert.Equal(4, result);
    }

    [Fact]
    public void Test2()
    {
        Assert.Equal(6, LengthOfLastWord.Soln("luffy is still joyboy"));
    }
}