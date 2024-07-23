namespace Challenges.Tests;

public class SortArrayIncreasingFreqTests
{
    [Fact]
    public void Test1()
    {
        int[] input = [1, 2, 3, 1, 2, 3, 1, 2, 3];

        int[] result = SortArrayIncreasingFreq.Soln(input);

        int[] expectedResult = [3, 3, 3, 2, 2, 2, 1, 1, 1];
        for (int i = 0; i < expectedResult.Length; i += 1)
        {
            Assert.Equal(expectedResult[i], result[i]);
        }
    }

    [Fact]
    public void Test2()
    {
        int[] input = [1, 1, 2, 2, 2, 4, 4, 4, 4];

        int[] result = SortArrayIncreasingFreq.Soln(input);
    
        int[] expectedResult = [1, 1, 2, 2, 2, 4, 4, 4, 4];
        for (int i = 0; i < expectedResult.Length; i += 1)
        {
            Assert.Equal(expectedResult[i], result[i]);
        }
    }

    [Fact]
    public void Test3()
    {
        int[] input = [];

        int[] result = SortArrayIncreasingFreq.Soln(input);

        Assert.Empty(result);
    }

    [Fact]
    public void Test4()
    {
        int[] input = [-1,1,-6,4,5,-6,1,4,1];

        int[] result = SortArrayIncreasingFreq.Soln(input);

        int[] expectedResult = [5,-1,4,4,-6,-6,1,1,1];
        for (int i = 0; i < expectedResult.Length; i += 1)
        {
            Assert.Equal(expectedResult[i], result[i]);
        }
    }
}