namespace Challenges.Tests;

public class ReverseSubstringsInsideParenthesesTests
{
    [Fact]
    public void Test1()
    {
        string input = "(u(evol)i)";

        string result = ReverseSubstringsInsideParentheses.ReverseParentheses(input);

        Assert.Equal("ievolu", result);
    }

    [Fact]
    public void Test2()
    {
        string input = "(u(evol)i)";

        string otherSolnResult = ReverseSubstringsInsideParentheses.AnotherSoln(input);

        Assert.Equal("ievolu", otherSolnResult);
    }

    [Fact]
    public void Test3()
    {
        string input = "(ed(et(oc))el)";

        string otherSolnResult = ReverseSubstringsInsideParentheses.AnotherSoln(input);

        Assert.Equal("leetcode", otherSolnResult);
    }

    [Fact]
    public void Test4()
    {
        ReverseSubstringsInsideParentheses.AnotherSoln("obxdpc()z()cgeuqvpf(d())");
    }
}