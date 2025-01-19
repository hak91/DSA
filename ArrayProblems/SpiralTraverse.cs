namespace ArrayProblems;
internal class SpiralTraverse
{
    public class Program
    {
        public static List<int> SpiralTraverse(int[,] array)
        {
            var result = new List<int>();
            var m = array.GetLength(0);
            var n = array.GetLength(1);

            var startingRow = 0;
            var endingRow = m - 1;
            var startingColumn = 0;
            var endingColumn = n - 1;
            while (startingRow <= endingRow && startingColumn <= endingColumn)
            {

                result.AddRange(TraverseRowLeftToRight(array, startingRow, startingColumn, endingColumn));
                result.AddRange(TraverseColumnTopToBottom(array, startingRow, endingRow, endingColumn));

                if (startingRow != endingRow)
                {
                    result.AddRange(TraverseRowRightToLeft(array, endingRow, startingColumn, endingColumn));
                }

                if (startingColumn != endingColumn)
                {
                    result.AddRange(TraverseColumnBottomToTop(array, startingColumn, startingRow, endingRow));
                }

                startingRow++;
                endingRow--;
                startingColumn++;
                endingColumn--;
            }

            return result;
        }

        private static List<int> TraverseColumnBottomToTop(int[,] array, int startingColumn, int startingRow, int endingRow)
        {
            var result = new List<int>();

            for (var i = endingRow - 1; i > startingRow; i--)
            {
                result.Add(array[i, startingColumn]);
            }
            return result;
        }

        private static List<int> TraverseRowRightToLeft(int[,] array, int endingRow, int startingColumn, int endingColumn)
        {
            var result = new List<int>();

            for (var j = endingColumn - 1; j >= startingColumn; j--)
            {
                result.Add(array[endingRow, j]);
            }

            return result;
        }

        private static List<int> TraverseColumnTopToBottom(int[,] array, int startingRow, int endingRow, int endingColumn)
        {
            var result = new List<int>();

            for (var i = startingRow + 1; i <= endingRow; i++)
            {
                result.Add(array[i, endingColumn]);
            }
            return result;
        }

        private static List<int> TraverseRowLeftToRight(int[,] array, int startingRow, int startingColumn, int endingColumn)
        {
            var result = new List<int>();

            for (var j = startingColumn; j <= endingColumn; j++)
            {
                result.Add(array[startingRow, j]);
            }
            return result;
        }
    }
}