namespace Challenges.Tests;

public class MultiplyStringsTests
{
    [Fact]
    public void Test1()
    {
        Assert.Equal(44, MultiplyStrings.StringToInt("44"));
    }

    [Fact]
    public void Test2()
    {
        string n1 = "123";
        string n2 = "456";

        Assert.Equal(123, MultiplyStrings.StringToInt(n1));
        Assert.Equal(456, MultiplyStrings.StringToInt(n2));

        Assert.Equal("56088", MultiplyStrings.Multiply(n1, n2));
    }

    [Fact]
    public void Test3()
    {
        string n1 = "123456789";
        string n2 = "987654321";

        Assert.Equal(123456789, MultiplyStrings.StringToInt(n1));
        Assert.Equal(987654321, MultiplyStrings.StringToInt(n2));

        Assert.Equal("121932631112635269", MultiplyStrings.Multiply(n1, n2));
    }
}