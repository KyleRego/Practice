namespace Challenges.Tests;

public class TwoSortedArraysTests
{
    [Fact]
    public void Test1()
    {
        int[] nums1 = [1, 3, 6];
        int[] nums2 = [2, 4, 7, 10];

        Assert.Equal(4, TwoSortedArrays.FindMedian(nums1, nums2));
    }

    [Fact]
    public void Test2()
    {
        int[] nums1 = [1, 3];
        int[] nums2 = [2, 4];

        Assert.Equal(2.5, TwoSortedArrays.FindMedian(nums1, nums2));
    }
}