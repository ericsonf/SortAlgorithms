namespace SortAlgorithms;

public static class BubbleSort
{
    public static IEnumerable<int> Sort(List<int> numbers)
    {
        for (var i = 0; i <= numbers.Count - 2; i++)
        {
            for (var j = 0; j <= numbers.Count - 2; j++)
            {
                if (numbers[j] <= numbers[j + 1]) continue;
                (numbers[j + 1], numbers[j]) = (numbers[j], numbers[j + 1]);
            } 
        }
        return numbers;
    }
}