namespace SortAlgorithms;

public static class InsertionSort
{
    public static IEnumerable<int> Sort(List<int> numbers)
    {
        for (var i = 0; i < numbers.Count - 1; i++)
        {
            for (var j = i + 1; j > 0; j--)
            {
                if (numbers[j - 1] <= numbers[j]) continue;
                (numbers[j - 1], numbers[j]) = (numbers[j], numbers[j - 1]);
            }
        }
        return numbers;    
    }
}