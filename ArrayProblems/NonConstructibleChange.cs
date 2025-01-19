namespace ArrayProblems;
internal class NonConstructibleChange
{
    public class Program
    {
        public int NonConstructibleChange(int[] coins)
        {
            Array.Sort(coins);
            var maxChange = 1;

            for (int i = 0; i < coins.Length; i++)
            {
                if (coins[i] <= maxChange)
                {
                    maxChange += coins[i];
                }
                else
                {
                    break;
                }
            }

            return maxChange;
        }
    }

    public Program MyProgram { get; }

    public NonConstructibleChange()
    {
        this.MyProgram = new Program();
    }

}
