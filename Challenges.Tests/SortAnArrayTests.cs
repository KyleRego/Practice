namespace Challenges.Tests;

public class SortAnArrayTests
{
    [Fact]
    public void Test1()
    {
        int[] input = [3, 2, 1];
        Assert.Equal([1, 2, 3], SortAnArray.CountingSort(input));
    }
}