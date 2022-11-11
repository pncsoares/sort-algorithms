using SortAlgorithms.Helpers;
using SortAlgorithms.Interfaces;

namespace SortAlgorithms.BubbleSort;

public class BubbleSortAlgorithm : ISort
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

        for (var i = 0; i < array.Length; i++)
        {
            var t = array[i];
            var isSorted = true;

            for (var j = 1; j < array.Length - i; j++)
            {
                if (array[j] >= array[j - 1])
                {
                    continue;
                }

                ArrayHelper.Swap(array, j, j - 1);
                isSorted = false;
            }

            if (isSorted)
            {
                break;
            }
        }

        return array;
    }
}