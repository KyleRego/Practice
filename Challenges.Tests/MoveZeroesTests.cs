namespace Challenges.Tests;

public class MoveZeroesTests
{
    [Fact]
    public void Test1()
    {
        int[] nums = [0, 1, 0, 3, 12];

        MoveZeroes.Soln(nums);
    }
}