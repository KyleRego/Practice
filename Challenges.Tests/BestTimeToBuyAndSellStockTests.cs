namespace Challenges.Tests;

public class BestTimeToBuyAndSellStockTests
{
    [Fact]
    public void Test1()
    {
        Assert.Equal(5, BestTimeToBuyAndSellStock.MaxProfit2([7,1,5,3,6,4]));
    }
}