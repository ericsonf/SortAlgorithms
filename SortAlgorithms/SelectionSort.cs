namespace SortAlgorithms;

public static class SelectionSort
{
    public static IEnumerable<int> Sort(List<int> numbers)
    {
        var newListNumbers = new int[numbers.Count];
        for (var i = 0; i < newListNumbers.Length; i++)
        {
            var smallest = FindSmallest(numbers);
            newListNumbers[i] = numbers[smallest];
            numbers.RemoveAt(smallest);
        }
        return newListNumbers;
    }

    private static int FindSmallest(IReadOnlyList<int> numbers)
    {
        var smallest = numbers[0];
        var index = 0;
        for (var i = 0; i < numbers.Count; i++)
        {
            if (numbers[i] >= smallest) continue;
            smallest = numbers[i];
            index = i;
        }
        return index;
    }
}