namespace DynamicProgramming;
public class MaxSubsetSumNoAdjacentCalc
{
    public static int MaxSubsetSumNoAdjacent(int[] array)
    {
        if (array.Length == 0) return 0;

        var sumUntilMinusTwo = (array[0], true);

        if (array.Length == 1)
        {
            return sumUntilMinusTwo.Item1;
        }

        var sumUntilMinusOne = array[1] > array[0] ? (array[1], true) : (array[0], false);

        if (array.Length == 2)
        {
            return sumUntilMinusOne.Item1;
        }

        for (int i = 2; i < array.Length; i++)
        {
            var currentSum1 = sumUntilMinusTwo.Item1 + array[i];
            var currentSum2 = sumUntilMinusOne.Item2 ? sumUntilMinusOne.Item1 : sumUntilMinusOne.Item1 + array[i];

            if (currentSum1 >= currentSum2)
            {
                sumUntilMinusTwo = sumUntilMinusOne;
                sumUntilMinusOne = (currentSum1, true);
                continue;
            }
            sumUntilMinusTwo = sumUntilMinusOne;
            sumUntilMinusOne = (currentSum2, false);
        }

        return sumUntilMinusTwo.Item1 > sumUntilMinusOne.Item1 ? sumUntilMinusTwo.Item1 : sumUntilMinusOne.Item1;
    }
}
