namespace Challenges.Tests;

public class ValidParenthesesTests
{
    [Fact]
    public void Test1()
    {
        Assert.False(ValidParentheses.IsValid("[)"));
    }

    [Fact]
    public void Test2()
    {
        Assert.True(ValidParentheses.IsValid("[[]]()"));
    }

    [Fact]
    public void Test3()
    {
        Assert.True(ValidParentheses.IsValid("()[]{}"));
    }

    [Fact]
    public void Test4()
    {
        Assert.False(ValidParentheses.IsValid("((())){}}"));
    }
}