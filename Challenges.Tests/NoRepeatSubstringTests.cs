namespace Challenges.Tests;

public class NoRepeatSubstringTests
{
    [Fact]
    public void Test1()
    {
        string testString = "abbc";
        Assert.Equal(2, NoRepeatSubstringLength.Soln2(testString));
    }

    [Fact]
    public void Test2()
    {
        string testString = "abcabcbb";
        Assert.Equal(3, NoRepeatSubstringLength.Soln2(testString));
    }

    [Fact]
    public void Test3()
    {
        string testString = "555das456h5f3";
        Assert.Equal(7, NoRepeatSubstringLength.Soln2(testString));
    }

    [Fact]
    public void Test4()
    {
        string testString = "aab";
        Assert.Equal(2, NoRepeatSubstringLength.Soln2(testString));
    }

    [Fact]
    public void Test5()
    {
        string testString = "dvdf";
        Assert.Equal(3, NoRepeatSubstringLength.Soln2(testString));
    }

    [Fact]
    public void Test6()
    {
        string testString = "a";
        Assert.Equal(1, NoRepeatSubstringLength.Soln2(testString));
    }
}