using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetcodeSharp
{
    //https://leetcode.com/problems/best-time-to-buy-and-sell-stock-ii/
    public class BestTimetoBuyandSellStockII
    {
        public int MaxProfit(int[] prices)
        {
            if (prices == null || prices.Length < 2)
                return 0;
            int profit = 0;
            int bidprice = prices[0];
            for (int i = 1; i < prices.Length; i++)
            {
                if (prices[i] > bidprice)
                {
                    profit += (prices[i] - bidprice);
                    bidprice = prices[i];
                }
                else if (prices[i] < bidprice)
                    bidprice = prices[i];
            }
            return profit;
        }
    }
}
