namespace Challenges.Tests;

public class PascalsTriangleTests
{
    [Fact]
    public void Test1()
    {
        IList<IList<int>> result = PascalsTriangle.Soln(1);

        Assert.Equal(1, result[0][0]);
    }

    [Fact]
    public void Test2()
    {
        IList<IList<int>> result = PascalsTriangle.Soln(2);

        Assert.Equal(1, result[0][0]);
        Assert.Equal(1, result[1][0]);
        Assert.Equal(1, result[1][1]);
    }

    [Fact]
    public void Test3()
    {
        IList<IList<int>> result = PascalsTriangle.Soln(3);

        Assert.Equal(1, result[0][0]);
        Assert.Equal(1, result[1][0]);
        Assert.Equal(1, result[1][1]);
        Assert.Equal(1, result[2][0]);
        Assert.Equal(2, result[2][1]);
        Assert.Equal(1, result[2][2]);
    }
}