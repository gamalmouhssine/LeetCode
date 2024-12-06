public class Solution {
    public int MaxProfit(int[] prices) {
        var Profit = 0;
        var MinPrice = int.MaxValue;
        var maxProfit = 0;
        for (var i = 0; i < prices.Length; i++) {
          if (prices[i] < MinPrice) {
            MinPrice = prices[i];
          }else{
            Profit = prices[i] - MinPrice;
            if (Profit > maxProfit) {
              maxProfit = Profit;
            }
          }
        }
      return maxProfit;
    }
}