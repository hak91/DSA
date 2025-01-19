using ArrayProblems;

var answer = MergeOverlappingIntervals.Program.MergeOverlappingIntervals([
    [2, 3],
    [4, 5],
    [6, 7],
    [8, 9],
    [1, 10]
  ]);
Console.WriteLine(string.Join("; ", answer.Select(x => string.Join(", ", x))));