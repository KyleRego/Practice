namespace Challenges.Tests;

public class ClimbingStairsTests
{
    [Fact]
    public void Test1()
    {
        int result = ClimbingStairs.ClimbStairs(1);

        Assert.Equal(1, result);
    }

    [Fact]
    public void Test2()
    {
        int result = ClimbingStairs.ClimbStairs(2);

        // 1 1
        // 2

        Assert.Equal(2, result);
    }

    [Fact]
    public void Test3()
    {
        int result = ClimbingStairs.ClimbStairs(3);

        // 1 1 1
        //   2 1
        // 1   2

        Assert.Equal(3, result);
    }

    [Fact]
    public void Test4()
    {
        int result = ClimbingStairs.ClimbStairs(4);

        // 1 1 1 1
        //   2 1 1
        // 1   2 1
        // 1 1   2
        //   2   2
        Assert.Equal(5, result);
    }

    [Fact]
    public void Test5()
    {
        int result = ClimbingStairs.ClimbStairs(5);

        // 1 1 1 1 1
        // 2 1 1 1
        // 1 2 1 1
        // 1 1 2 1
        // 1 1 1 2
        // 1 2 2
        // 2 1 2
        // 2 2 1

        Assert.Equal(8, result);
    }
}