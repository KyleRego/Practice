namespace Challenges.Tests;

public class SymmetricTreeTests
{
    [Fact]
    public void Test1()
    {
        TreeNode root = new()
        {
            val = 1,
            left = new()
            {
                val = 2,
                left = new()
                {
                    val = 3
                },
                right = new()
                {
                    val = 4
                }
            },
            right = new()
            {
                val = 2,
                left = new()
                {
                    val = 4
                },
                right = new()
                {
                    val = 3
                }
            }
        };

        Assert.True(SymmetricTree.IsSymmetric(root));
    }
}