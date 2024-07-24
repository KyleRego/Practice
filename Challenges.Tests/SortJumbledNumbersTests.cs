namespace Challenges.Tests;

public class SortJumbledNumbersTests
{
    [Fact]
    public void Test1()
    {
        int[] mapping = [8,9,4,0,2,1,3,5,7,6];
        int[] nums = [991,338,38];

        int[] result = new SortJumbledNumbers().Soln(mapping, nums);

        int[] expected = [338,38,991];

        for (int i = 0; i < expected.Length; i += 1)
        {
            Assert.Equal(expected[i], result[i]);
        }
    }

    [Fact]
    public void Test2()
    {
        int[] mapping = [9,8,7,6,5,4,3,2,1,0];

        int[] nums = [0,1,2,3,4,5,6,7,8,9];

        int[] result = new SortJumbledNumbers().Soln(mapping, nums);

        int[] expected = [9,8,7,6,5,4,3,2,1,0];

        for (int i = 0; i < expected.Length; i += 1)
        {
            Assert.Equal(expected[i], result[i]);
        }
    }
}