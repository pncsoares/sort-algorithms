using SortAlgorithms.Helpers;
using SortAlgorithms.Interfaces;

namespace SortAlgorithms.SelectionSort;

public class SelectionSortAlgorithm : ISort
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

        for (var i = 0; i < array.Length - 1; i++)
        {
            var jMin = i;
            
            for (var j = i + 1; j < array.Length; j++)
            {
                if (array[j] < array[jMin])
                {
                    jMin = j;
                }
            }

            if (jMin != i)
            {
                ArrayHelper.Swap(array, i, jMin);
            }
        }

        return array;
    }
}