namespace Challenges.Tests;

public class LongestPalindromicStringTests
{
    [Fact]
    public void Test1()
    {
        string result = LongestPalindromicString.Soln("babad");
        Assert.Equal("bab", result);
    }

    [Fact]
    public void Test2()
    {
        string result = LongestPalindromicString.Soln("a");
        Assert.Equal("a", result);
    }

    [Fact]
    public void IsPalindromeTests()
    {
        Assert.True(LongestPalindromicString.IsPalindrome("aa"));
        Assert.True(LongestPalindromicString.IsPalindrome("bab"));
        Assert.False(LongestPalindromicString.IsPalindrome("baba"));
    }

    [Fact]
    public void IsPalindrome2Tests()
    {
        Assert.True(LongestPalindromicString.IsPalindrome2("aa"));
        Assert.True(LongestPalindromicString.IsPalindrome2("bab"));
        Assert.False(LongestPalindromicString.IsPalindrome2("baba"));
    }
}