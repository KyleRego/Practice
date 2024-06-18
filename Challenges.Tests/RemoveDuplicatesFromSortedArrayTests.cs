namespace Challenges.Tests;

public class RemoveDuplicatesFromSortedArrayTests
{
    [Fact]
    public void Test1()
    {
        int[] nums = [0,0,1,1,1,2,2,3,3,4];

        int[] expectedNums = [0, 1, 2, 3, 4];
        int expectedUniqueCount = expectedNums.Length;
        int uniqueCount = RemoveDuplicatesFromSortedArray.RemoveDuplicates(nums);

        Assert.Equal(expectedUniqueCount, uniqueCount);

        for (int i = 0; i < expectedUniqueCount; i += 1)
        {
            Assert.Equal(expectedNums[i], nums[i]);
        }
    }

    [Fact]
    public void Test2()
    {
        int[] nums = [1, 1];

        int[] expectedNums = [1];
        int expectedUniqueCount = expectedNums.Length;
        int uniqueCount = RemoveDuplicatesFromSortedArray.RemoveDuplicates(nums);

        Assert.Equal(expectedUniqueCount, uniqueCount);

        for (int i = 0; i < expectedUniqueCount; i += 1)
        {
            Assert.Equal(expectedNums[i], nums[i]);
        }
    }
}