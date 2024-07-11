namespace Challenges.Tests;

public class CrawlerLogFooterTests
{
    [Fact]
    public void Test1()
    {
        string[] input = ["d1/","d2/","./","d3/","../","d31/"];

        int result = CrawlerLogFooter.MinOperations(input);

        Assert.Equal(3, result);

        int otherSolnResult = CrawlerLogFooter.StackSoln(input);

        Assert.Equal(3, otherSolnResult);
    }
}