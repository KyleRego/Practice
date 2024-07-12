namespace Challenges.Tests;

public class MaximumScoreFromRemovingSubstringsTests
{
    [Fact]
    public void Test1()
    {
        string s = "cdbcbbaaabab";
        int x = 4;
        int y = 5;

        int result = MaximumScoreFromRemovingSubstrings.MaximumGain(s, x, y);
        Assert.Equal(19, result);
    }

    [Fact]
    public void Test2()
    {
        string s = "aabbaaxybbaabb";
        int x = 5;
        int y = 4;

        int result = MaximumScoreFromRemovingSubstrings.MaximumGain(s, x, y);
        Assert.Equal(20, result);
    }
}