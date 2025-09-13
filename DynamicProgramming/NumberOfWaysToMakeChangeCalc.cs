namespace DynamicProgramming;
public class NumberOfWaysToMakeChangeCalc
{
    public static int NumberOfWaysToMakeChange(int n, int[] denoms)
    {
        var ways = new int[n + 1];
        ways[0] = 1;

        foreach (var denom in denoms)
        {
            for (int amount = 1; amount <= n; amount++)
            {
                if (denom <= amount)
                {
                    ways[amount] += ways[amount - denom];
                }
            }
        }
        return ways[n];
    }
}
