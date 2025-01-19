namespace SortingAlgorithms;

public class InsertionSortAlgorithm : ISortingAlgorithm
{
    public List<int> Sort(List<int> myList)
    {
        var sortedList = new List<int>(myList);
        var numOfElements = sortedList.Count;
        for (var index = 0; index < numOfElements; index++)
        {
            var currentIndex = index;
            while (currentIndex > 0 && sortedList[currentIndex - 1] > sortedList[currentIndex])
            {
                (sortedList[currentIndex - 1], sortedList[currentIndex]) = (sortedList[currentIndex], sortedList[currentIndex - 1]);
                currentIndex--;
            }

        }
        return sortedList;
    }
}
