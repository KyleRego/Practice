namespace Challenges.Tests;

public class BinarySearchTests
{
    [Fact]
    public void Test1()
    {
        int[] nums = [-1,0,3,5,9,12];

        int result = BinarySearch.Search(nums, 9);
        Assert.Equal(4, result);
    }
}