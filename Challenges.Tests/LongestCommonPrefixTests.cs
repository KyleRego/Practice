namespace Challenges.Tests;

public class LongestCommonPrefixTests
{
    [Fact]
    public void Test1()
    {
        Assert.Equal("fl" ,LongestCommonPrefix.Soln(["flower","flow","flight"]));
    }

    [Fact]
    public void Test2()
    {
        Assert.Equal("" ,LongestCommonPrefix.Soln(["dog","racecar","car"]));
    }
}