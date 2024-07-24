namespace Challenges.Tests;

public class SplitStringsTests
{
    [Fact]
    public void Test1()
    {
        string input = "abcd";

        string[] result = SplitString.Solution(input);

        Assert.Equal(2, result.Length);
        Assert.Equal("ab", result[0]);
        Assert.Equal("cd", result[1]);
    }

    [Fact]
    public void Test2()
    {
        string input = "tre";

        string[] result = SplitString.Solution(input);

        Assert.Equal(2, result.Length);
        Assert.Equal("tr", result[0]);
        Assert.Equal("e_", result[1]);
    }
}