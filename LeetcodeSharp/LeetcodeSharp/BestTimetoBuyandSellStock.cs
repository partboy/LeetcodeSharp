using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetcodeSharp
{
    //https://leetcode.com/problems/best-time-to-buy-and-sell-stock/
    public class BestTimetoBuyandSellStock
    {
        public int MaxProfit(int[] prices)
        {
            if (prices == null || prices.Length < 2)
                return 0;
            int min = prices[0];
            int profit = 0;
            for (int i = 1; i < prices.Length; i++)
            {
                if (prices[i] < min)
                    min = prices[i];
                else
                    profit = Math.Max(profit, prices[i] - min);
            }
            return profit;
        }
    }
}
