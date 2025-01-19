
namespace Graphs;
internal class RemoveIslands
{
    public Program MyProgram
    {
        get
        {
            return new Program();
        }
    }
    public class Program
    {
        public int[][] RemoveIslands(int[][] matrix)
        {
            var numRows = matrix.Length;
            var numCols = matrix[0].Length;
            if (numRows == 0 || numCols == 0)
            {
                return matrix;
            }
            var visitedNodes = new bool[matrix.Length, matrix[0].Length];

            //first row
            for (int j = 0; j < matrix[0].Length; j++)
            {
                if (visitedNodes[0, j])
                {
                    continue;
                }

                TraveseFromNode(0, j, matrix, numRows, numCols, visitedNodes, false);
            }

            //lastRow
            for (int j = 0; j < matrix[0].Length; j++)
            {
                if (visitedNodes[numRows - 1, j])
                {
                    continue;
                }

                TraveseFromNode(numRows - 1, j, matrix, numRows, numCols, visitedNodes, false);
            }

            //first Column
            for (int i = 0; i < matrix.Length; i++)
            {
                if (visitedNodes[i, 0])
                {
                    continue;
                }

                TraveseFromNode(i, 0, matrix, numRows, numCols, visitedNodes, false);
            }

            // lastColumn
            for (int i = 0; i < matrix.Length; i++)
            {
                if (visitedNodes[i, numCols - 1])
                {
                    continue;
                }

                TraveseFromNode(i, numCols - 1, matrix, numRows, numCols, visitedNodes, false);
            }

            for (int i = 0; i < matrix.Length; i++)
            {
                for (int j = 0; j < matrix[i].Length; j++)
                {
                    if (visitedNodes[i, j])
                    {
                        continue;
                    }
                    TraveseFromNode(i, j, matrix, numRows, numCols, visitedNodes, true);

                }
            }

            return matrix;
        }

        private void TraveseFromNode(int row, int col, int[][] matrix, int numRows, int numCols, bool[,] visitedNodes, bool inverse)
        {
            var queue = new Queue<(int, int)>();
            queue.Enqueue((row, col));
            while (queue.Count > 0)
            {
                var (currentRow, currentColumn) = queue.Dequeue();
                visitedNodes[currentRow, currentColumn] = true;
                if (matrix[currentRow][currentColumn] == 0)
                {
                    continue;
                }
                if (inverse)
                {
                    matrix[currentRow][currentColumn] = 0;
                }
                foreach (var node in GetNeighborsOf(currentRow, currentColumn, numRows, numCols, visitedNodes))
                {
                    queue.Enqueue(node);
                }
            }
        }
        private IEnumerable<(int, int)> GetNeighborsOf(int i, int j, int numRows, int numCols, bool[,] visitedNodes)
        {
            // Right
            if (i + 1 >= 0 && i + 1 < numRows && !visitedNodes[i + 1, j])
            {
                yield return (i + 1, j);
            }
            // Left
            if (i - 1 >= 0 && i - 1 < numRows && !visitedNodes[i - 1, j])
            {
                yield return (i - 1, j);
            }
            //Up
            if (j - 1 >= 0 && j - 1 < numCols && !visitedNodes[i, j - 1])
            {
                yield return (i, j - 1);
            }
            //Down
            if (j + 1 >= 0 && j + 1 < numCols && !visitedNodes[i, j + 1])
            {
                yield return (i, j + 1);
            }
        }
    }
}
