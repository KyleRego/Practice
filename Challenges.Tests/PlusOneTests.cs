namespace Challenges.Tests;

public class PlusOneTests
{
    [Fact]
    public void Test1()
    {
        int[] input = [1, 2, 3];
        int[] expected = [1, 2, 4];

        int[] result = PlusOne.Soln(input);

        for (int i = 0; i < expected.Length; i += 1)
        {
            Assert.Equal(expected[i], result[i]);
        }
    }

    [Fact]
    public void Test2()
    {
        int[] input = [9];
        int[] expected = [1, 0];

        int[] result = PlusOne.Soln(input);

        for (int i = 0; i < expected.Length; i += 1)
        {
            Assert.Equal(expected[i], result[i]);
        }
    }

    [Fact]
    public void Test3()
    {
        int[] input = [4,3,2,1];
        int[] expected = [4,3,2,2];

        int[] result = PlusOne.Soln(input);

        for (int i = 0; i < expected.Length; i += 1)
        {
            Assert.Equal(expected[i], result[i]);
        }
    }
}