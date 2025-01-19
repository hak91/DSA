namespace Graphs;
internal class RiverSizes
{
    public Program MyProgram { get { return new(); } }
    public class Program
    {
        public List<int> RiverSizes(int[,] matrix)
        {
            var visitedNodes = new Dictionary<(int, int), bool>();
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    visitedNodes.Add((i, j), false);
                }
            }
            var numRows = matrix.GetLength(0);
            var numCols = matrix.GetLength(1);
            var result = new List<int>();
            while (visitedNodes.Any(x => !x.Value))
            {
                var queue = new Queue<(int, int)>();
                var (parentRow, parentColumn) = visitedNodes.Where(x => !x.Value).First().Key;
                queue.Enqueue((parentRow, parentColumn));
                var riverSize = 0;
                while (queue.Count > 0)
                {
                    var (currentRow, currentColumn) = queue.Dequeue();
                    if (visitedNodes[(currentRow, currentColumn)])
                    {
                        continue;
                    }

                    visitedNodes[(currentRow, currentColumn)] = true;
                    if (matrix[currentRow, currentColumn] == 1)
                    {
                        riverSize++;
                        var neighbors = GetValidNeighbours(currentRow, currentColumn, numRows, numCols, visitedNodes);
                        foreach (var n in neighbors)
                        {
                            queue.Enqueue((n.Item1, n.Item2));

                        }
                    }
                }
                if (riverSize > 0)
                {
                    result.Add(riverSize);
                }

            }
            return result;
        }

        private List<(int, int)> GetValidNeighbours(int row, int column,
                                                    int numRows, int numCols,
                                                    Dictionary<(int, int), bool> visitedElements)
        {
            var result = new List<(int, int)>();
            if (row + 1 >= 0 && row + 1 < numRows && !visitedElements[(row + 1, column)])
            {
                result.Add((row + 1, column));
            }
            if (column + 1 >= 0 && column + 1 < numCols && !visitedElements[(row, column + 1)])
            {
                result.Add((row, column + 1));
            }
            if (row - 1 >= 0 && row - 1 < numRows && !visitedElements[(row - 1, column)])
            {
                result.Add((row - 1, column));
            }
            if (column - 1 >= 0 && column - 1 < numCols && !visitedElements[(row, column - 1)])
            {
                result.Add((row, column - 1));
            }

            return result;
        }
    }
}
