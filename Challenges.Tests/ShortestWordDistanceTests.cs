namespace Challenges.Tests;

public class ShortestWordDistanceTests
{
    [Fact]
    public void Test1()
    {
        string[] wordsDict = wordsDict = ["practice", "makes", "perfect", "coding", "makes"];

        string word1 = "coding";
        string word2 = "practice";

        Assert.Equal(3, ShortestWordDistance.ShortestDistance(wordsDict, word1, word2));
        Assert.Equal(3, ShortestWordDistance.OnePassSoln(wordsDict, word1, word2));
    }
}