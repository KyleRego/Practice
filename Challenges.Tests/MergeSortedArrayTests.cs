namespace Challenges.Tests;

public class MergedSortedArrayTests
{
    [Fact]
    public void Test1()
    {
        int[] nums1 = new int[2];
        int[] nums2 = [1, 2];
        int m = 0;
        int n = 2;

        MergeSortedArray.Merge(nums1, m, nums2, n);

        Assert.Equal(1, nums1[0]);
        Assert.Equal(2, nums1[1]);
    }

    [Fact]
    public void Test2()
    {
        int[] nums1 = [1,2,3,0,0,0];
        int m = 3;
        int[] nums2 = [2,5,6];
        int n = 3;

        MergeSortedArray.Merge(nums1, m, nums2, n);

        int[] expected = [1, 2, 2, 3, 5, 6];

        for (int k = 0; k < expected.Length; k += 1)
        {
            Assert.Equal(expected[k], nums1[k]);
        }
    }
}