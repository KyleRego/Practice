namespace Challenges.Tests;

public class IsSubsequenceTests
{
    [Fact]
    public void Test1()
    {
        string s = "abc";
        string t = "ahbgdc";

        bool result = IsSubsequence.Soln(s, t);
        Assert.True(result);
    }

    [Fact]
    public void Test2()
    {
        string s = "axc";
        string t = "ahbgdc";

        bool result = IsSubsequence.Soln(s, t);
        Assert.False(result);
    }
}