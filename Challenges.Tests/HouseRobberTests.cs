namespace Challenges.Tests;

public class HouseRobberTests
{
    [Fact]
    public void Test1()
    {
        int[] nums = [1,2,3,1];
        Assert.Equal(4, HouseRobber.Rob(nums));
    }

    [Fact]
    public void Test2()
    {
        int[] nums = [2,7,9,3,1];
        Assert.Equal(12, HouseRobber.Rob(nums));
    }

    [Fact]
    public void Test3()
    {
        int result = HouseRobber.Rob3(
            [183,219,57,193,
            94,233,202,154,65,
            240,97,234,100,249,186,
            66,90,238,168,128,177,
            235,50,81,185,165,217,
            207,88,80,112,78,135,62,228,247,211]);
    }

    [Fact]
    public void Test4()
    {
        int[] nums = [6,6,4,8,4,3,3,10];
        Assert.Equal(27, HouseRobber.Rob(nums));
    }

    [Fact]
    public void Test5()
    {
        int[] nums = [5];
        Assert.Equal(5, HouseRobber.Rob(nums));
    }

    [Fact]
    public void Test6()
    {
        int[] nums = [2, 8];
        Assert.Equal(8, HouseRobber.Rob(nums));
    }
}