namespace Challenges.Tests;

public class RomanNumeralTests
{
    [Fact]
    public void Test1()
    {
        Assert.Equal(1, RomanNumeral.RomanToInt2("I"));
        Assert.Equal(2, RomanNumeral.RomanToInt2("II"));
        Assert.Equal(3, RomanNumeral.RomanToInt2("III"));
        Assert.Equal(5, RomanNumeral.RomanToInt2("V"));
        Assert.Equal(10, RomanNumeral.RomanToInt2("X"));
        Assert.Equal(50, RomanNumeral.RomanToInt2("L"));
        Assert.Equal(100, RomanNumeral.RomanToInt2("C"));
        Assert.Equal(500, RomanNumeral.RomanToInt2("D"));
        Assert.Equal(1000, RomanNumeral.RomanToInt2("M"));
    }

    [Fact]
    public void Test2()
    {
        Assert.Equal(7, RomanNumeral.RomanToInt2("VII"));
        Assert.Equal(27, RomanNumeral.RomanToInt2("XXVII"));
    }

    [Fact]
    public void Test3()
    {
        Assert.Equal(4, RomanNumeral.RomanToInt2("IV"));
        Assert.Equal(40, RomanNumeral.RomanToInt2("XL"));
    }

    [Fact]
    public void Test4()
    {
        Assert.Equal(1994, RomanNumeral.RomanToInt2("MCMXCIV"));
    }
}