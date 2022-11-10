using SortAlgorithms.Interfaces;

namespace SortAlgorithms.InsertionSort;

/// <inheritdoc />
public class InsertionSortAlgorithm : ISort
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
        
        for (var i = 1; i < array.Length; i++)
        {
            var current = array[i];
            var j = i - 1;

            while (j >= 0 && array[j] > current)
            {
                array[j + 1] = array[j];
                j--;
            }

            array[j + 1] = current;
        }

        return array;
    }
}