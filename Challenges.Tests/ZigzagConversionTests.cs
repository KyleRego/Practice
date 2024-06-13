namespace Challenges.Tests;

public class ZigzagConversionTests
{
    [Fact]
    public void Test1()
    {
        string result = ZigzagConversion.Soln("paypalishiring", 4);
        Assert.Equal("pinalsigyahrpi" , result);
    }

    [Fact]
    public void Test2()
    {
        string result = ZigzagConversion.Soln("A", 1);
        Assert.Equal("A", result);
    }
}