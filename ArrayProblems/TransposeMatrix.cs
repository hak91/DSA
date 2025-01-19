namespace ArrayProblems;
internal static class TransposeMatrix
{
    public class Program
    {
        public int[,] TransposeMatrix(int[,] matrix)
        {
            var m = matrix.GetLength(0);
            var n = matrix.GetLength(1);

            var transpose = new int[n, m];

            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    transpose[j, i] = matrix[i, j];
                }
            }
            return transpose;
        }
    }
}
