namespace Challenges.Tests;

public class ThreeSumTests
{
    [Fact]
    public void Test1()
    {
        int[] input = [1, -1, 0];

        IList<IList<int>> expected = [input];

        IList<IList<int>> result = ThreeSum.Soln1(input);

        Assert.Equal(expected.Count, result.Count);

        for (int i = 0; i < result.Count; i += 1)
        {
            Assert.Equal(expected[i], result[i]);
        }
    }

    [Fact]
    public void Test2()
    {
        int[] input = [-1,0,1,2,-1,-4];

        IList<IList<int>> expected = [[-1,-1,2],[-1,0,1]];

        IList<IList<int>> result = ThreeSum.Soln1(input);

        Assert.Equal(expected.Count, result.Count);

    }
}