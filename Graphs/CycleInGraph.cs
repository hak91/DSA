namespace Graphs;
internal class CycleInGraph
{
    public Program MyProgram => new();
    public class Program
    {
        public bool CycleInGraph(int[][] edges)
        {
            // Write your code here.

            var numberOfNodes = edges.Length;
            var visitedNodes = new bool[numberOfNodes];
            var currentlyInStack = new bool[numberOfNodes];

            for (int i = 0; i < numberOfNodes; i++)
            {
                if (visitedNodes[i])
                {
                    continue;
                }

                var containsCycle = IsNodeInCycle(edges, i, visitedNodes, currentlyInStack);

                if (containsCycle)
                {
                    return true;
                }
            }
            return false;
        }

        private bool IsNodeInCycle(int[][] edges, int node, bool[] visitedNodes, bool[] currentlyInStack)
        {
            visitedNodes[node] = true;
            currentlyInStack[node] = true;

            foreach (var child in edges[node])
            {
                if (!visitedNodes[child])
                {
                    var containsCylde = IsNodeInCycle(edges, child, visitedNodes, currentlyInStack);

                    if (containsCylde)
                    {
                        return true;
                    }
                }

                else if (currentlyInStack[child])
                {
                    return true;
                }
            }

            currentlyInStack[node] = false;

            return false;
        }
    }

}
