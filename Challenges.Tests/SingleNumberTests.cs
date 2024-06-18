namespace Challenges.Tests;

public class SingleNumberTests
{
    [Fact]
    public void Test1()
    {
        int[] input = [1, 2, 3, 4, 4, 3, 2];

        int result = SingleNumber.Soln(input);

        Assert.Equal(1, result);
    }

    [Fact]
    public void Test2()
    {
        int[] input = [5];

        int result = SingleNumber.Soln(input);

        Assert.Equal(5, result);
    }
}