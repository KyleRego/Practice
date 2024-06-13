namespace Challenges.Tests;

public class RootEqualsSumOfChildrenTests
{
    [Fact]
    public void Test1()
    {
        TreeNode tree = new(
            10,
            new(5),
            new(5)
        );

        Assert.True(RootEqualsSumOfChildren.Soln(tree));
    }

    [Fact]
    public void Test2()
    {
        TreeNode tree = new(
            10,
            new(4),
            new(5)
        );

        Assert.False(RootEqualsSumOfChildren.Soln(tree));
    }
}