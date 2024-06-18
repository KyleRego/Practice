namespace Challenges.Tests;

public class RemoveElementTests
{
    [Fact]
    public void Test1()
    {
        int[] nums = [3,2,2,3];
        int val = 3;

        int result = RemoveElement.Soln(nums, val);

        Assert.Equal(2, result);
        Assert.Equal(2, nums[0]);
        Assert.Equal(2, nums[1]);
    }

    [Fact]
    public void Test2()
    {
        int[] nums = [0,1,2,2,3,0,4,2];
        int val = 2;

        int result = RemoveElement.Soln(nums, val);

        Assert.Equal(5, result);

        int[] expected = [0, 1, 3, 0, 4];

        for (int i = 0; i < expected.Length; i += 1)
        {
            Assert.Equal(expected[i], nums[i]);
        }
    }
}