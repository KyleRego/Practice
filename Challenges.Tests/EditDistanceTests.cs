namespace Challenges.Tests;

public class EditDistanceTests
{
    [Fact]
    public void Test1()
    {
        string word1 = "horse";
        string word2 = "ros";

        Assert.Equal(3, EditDistance.MinDistance(word1, word2));
    }

    [Fact]
    public void Test2()
    {
        string word1 = "intention";
        string word2 = "execution";

        Assert.Equal(5, EditDistance.MinDistance(word1, word2));
    }

    [Fact]
    public void Test3()
    {
        string word1 = "dog";
        string word2 = "dog";

        Assert.Equal(0, EditDistance.MinDistance(word1, word2));
    }

    [Fact]
    public void Test4()
    {
        string word1 = "spartan";
        string word2 = "part";

        Assert.Equal(3, EditDistance.MinDistance(word1, word2));
    }

    [Fact]
    public void Test5()
    {
        string word1 = "plasma";
        string word2 = "altruism";

        Assert.Equal(6, EditDistance.MinDistance(word1, word2));
    }
}