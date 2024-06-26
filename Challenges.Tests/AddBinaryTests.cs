namespace Challenges.Tests;

public class AddBinaryTests
{
    [Fact]
    public void Test1()
    {
        string inp1 = "11";
        string inp2 = "1";

        Assert.Equal("100", AddBinary.Soln(inp1, inp2));
    }

    [Fact]
    public void Test2()
    {
        string inp1 = "1010";
        string inp2 = "1011";

        Assert.Equal("10101", AddBinary.Soln(inp1, inp2));
    }

    [Fact]
    public void Test3()
    {
        string inp1 = "1111";
        string inp2 = "1111";

        Assert.Equal("11110", AddBinary.Soln(inp1, inp2));
    }
}