namespace Challenges.Tests;

public class ApplyOperationsToAnArrayTests
{
    [Fact]
    public void Test1()
    {
        int[] nums = [1,2,2,1,1,0];

        int[] result = ApplyOperationsToAnArray.ApplyOperations(nums);

        int[] expected = [1,4,2,0,0,0];

        for (int i = 0; i < expected.Length; i += 1)
        {
            Assert.Equal(expected[i], result[i]);
        }
    }

    [Fact]
    public void Test2()
    {
        int[] nums = [847,847,0,0,0,399,416,416,879,879,206,206,206,272];

        int[] result = ApplyOperationsToAnArray.ApplyOperations(nums);

        int[] expected = [1694,399,832,1758,412,206,272,0,0,0,0,0,0,0];

        for (int i = 0; i < expected.Length; i += 1)
        {
            Assert.Equal(expected[i], result[i]);
        }
    }
}