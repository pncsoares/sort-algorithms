using SortAlgorithms.Helpers;
using SortAlgorithms.Interfaces;

namespace SortAlgorithms.QuickSort;

/// <inheritdoc />
public class QuickSortAlgorithm : ISort
{
    public int[] Sort(int[] array)
    {
        if (array == null)
        {
            throw new ArgumentNullException(nameof(array));
        }

        if (array.Length < 2)
        {
            throw new ArgumentException($"The array must contain at least two elements! The passed array has {array.Length} elements.");
        }

        return Sort(array, 0, array.Length - 1);
    }

    private static int[] Sort(int[] array, int left, int right)
    {
        var i = left;
        var j = right;

        var pivot = array[(left + right) / 2];

        while (i <= j)
        {
            while (array[i] < pivot)
            {
                i++;
            }
            
            while (array[j] > pivot)
            {
                j--;
            }

            if (i > j)
            {
                continue;
            }
            
            ArrayHelper.Swap(array, i, j);

            i++;
            j--;
        }

        if (left < j)
        {
            Sort(array, left, j);
        }
        
        if (i < right)
        {
            Sort(array, i, right);
        }

        return array;
    }
}