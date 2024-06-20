namespace Challenges;

public class BestTimeToBuyAndSellStock
{
    // naive solution with O(n^2) time complexity
    public static int MaxProfit(int[] prices)
    {
        int bestProfit = 0;

        for (int i = 0; i < prices.Length; i += 1)
        {
            for (int j = i + 1; j < prices.Length; j += 1)
            {
                int buyPrice = prices[i];
                int sellPrice = prices[j];

                int profit = sellPrice - buyPrice;

                if (profit > bestProfit)
                {
                    bestProfit = profit;
                }
            }
        }

        return bestProfit;
    }

    public static int MaxProfit2(int[] prices)
    {
        int minPrice = int.MaxValue;
        int bestProfit = 0;

        for (int i = 0; i < prices.Length; i += 1)
        {
            int price = prices[i];

            if (price < minPrice)
            {
                minPrice = price;
            }
            else if (price - minPrice > bestProfit)
            {
                bestProfit = price - minPrice;
            }
        }

        return bestProfit;
    }
}