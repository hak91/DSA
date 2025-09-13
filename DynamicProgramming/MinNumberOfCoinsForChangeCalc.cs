namespace DynamicProgramming;
public class MinNumberOfCoinsForChangeCalc
{
    public static int MinNumberOfCoinsForChange(int n, int[] denoms)
    {
        // Write your code here.
        int[] minCoins = new int[n + 1];
        Array.Fill(minCoins, int.MaxValue);
        minCoins[0] = 0;
        int toCompare = 0;
        foreach (var denom in denoms)
        {
            for (var amount = 1; amount <= n; amount++)
            {
                if (denom <= amount)
                {
                    if (minCoins[amount - denom] == int.MaxValue)
                    {
                        toCompare = minCoins[amount - denom];
                    }
                    else
                    {
                        toCompare = minCoins[amount - denom] + 1;
                    }
                    minCoins[amount] = Math.Min(toCompare, minCoins[amount]);
                }
            }
        }
        return minCoins[n] == int.MaxValue ? -1 : minCoins[n];
    }
}
