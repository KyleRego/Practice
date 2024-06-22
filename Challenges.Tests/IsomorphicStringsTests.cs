namespace Challenges.Tests;

public class IsomorphicStringsTests
{
    [Fact]
    public void Test1()
    {
        string s = "egg", t = "add";

        Assert.True( IsomorphicStrings.IsIsomorphic(s, t) );
    }

    [Fact]
    public void Test2()
    {
        string s = "foo", t = "bar";

        Assert.False( IsomorphicStrings.IsIsomorphic(s, t) );
    }

    [Fact]
    public void Test3()
    {
        string s = "paper", t = "title";

        Assert.True( IsomorphicStrings.IsIsomorphic(s, t) );
    }

    [Fact]
    public void Test4()
    {
        string s = "badc", t = "baba";

        Assert.False( IsomorphicStrings.IsIsomorphic(s, t) );
    }
}