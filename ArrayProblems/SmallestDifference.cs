namespace ArrayProblems;
internal class SmallestDifference
{
    public class Program
    {
        public static int[] SmallestDifference(int[] arrayOne, int[] arrayTwo)
        {
            Array.Sort(arrayOne);
            Array.Sort(arrayTwo);

            int i = 0;
            int j = 0;
            var result = new int[2];
            var currentMinDifference = Int32.MaxValue;
            while (i < arrayOne.Length && j < arrayTwo.Length)
            {
                int first = arrayOne[i];
                int second = arrayTwo[j];
                if (first == second)
                {
                    return new int[2] { first, second };
                }
                int difference;
                if (first < second)
                {
                    difference = second - first;
                    i++;
                }
                else
                {
                    difference = first - second;
                    j++;
                }

                if (difference < currentMinDifference)
                {
                    currentMinDifference = difference;
                    result = new int[2] { first, second };
                }

            }
            return result;
        }
    }
}
