namespace SortAlgorithms;

public static class QuickSort
{
    public static IEnumerable<int> Sort(List<int> numbers, int left, int right)
    {
        if (left < right)
        {
            var pivot = Partition(numbers, left, right);

            if (pivot > 1) Sort(numbers, left, pivot - 1);
            
            if (pivot + 1 < right) Sort(numbers, pivot + 1, right);
        }
        return numbers;
    }

    private static int Partition(IList<int> numbers, int left, int right)
    {
        var pivot = numbers[left];
        while (true) 
        {
            while (numbers[left] < pivot)
                left++;

            while (numbers[right] > pivot)
                right--;

            if (left < right)
            {
                if (numbers[left] == numbers[right]) return right;

                (numbers[left], numbers[right]) = (numbers[right], numbers[left]);
            }
            else
                return right;
        }
    }
}