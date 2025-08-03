using Graphs;

//int[][] input = [
//  [1, 0, 0, 0, 0, 0],
//  [0, 1, 0, 1, 1, 1],
//  [0, 0, 1, 0, 1, 0],
//  [1, 1, 0, 0, 1, 0],
//  [1, 0, 1, 1, 0, 0],
//  [1, 0, 0, 0, 0, 1]
//];

//var removeIslands = new RemoveIslands();
//Console.WriteLine(removeIslands.MyProgram.RemoveIslands(input));

int[][] edges = [
  [1, 3],
  [2, 3, 4],
  [0],
  [],
  [2, 5],
  []
];

var cycleInGraph = new CycleInGraph();
Console.WriteLine(cycleInGraph.MyProgram.CycleInGraph(edges));