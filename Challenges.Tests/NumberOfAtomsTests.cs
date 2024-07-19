namespace Challenges.Tests;

public class NumberOfAtomsTests
{
    [Fact]
    public void Test1()
    {
        string input = "H2O";

        var result = NumberOfAtoms.Soln(input);

        Assert.Equal(2, result['H']);
        Assert.Equal(1, result['O']);
    }
}