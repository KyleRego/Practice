namespace Challenges.Tests;

public class SearchInsertPositionTests
{
    [Fact]
    public void Test1()
    {
        int[] nums = [1,3,5,6];
        int target = 5;

        Assert.Equal(2, SearchInsertPosition.SearchInsert(nums, target));
    }

    [Fact]
    public void Test2()
    {
        int[] nums = [1,3,5,6];
        int target = 2;

        Assert.Equal(1, SearchInsertPosition.SearchInsert(nums, target));
    }

    [Fact]
    public void Test3()
    {
        int[] nums = [1,3,5,6];
        int target = 7;

        Assert.Equal(4, SearchInsertPosition.SearchInsert(nums, target));
    }
}