using SortAlgorithms.Helpers;
using SortAlgorithms.Interfaces;

namespace SortAlgorithms.HeapSort;

public class HeapSortAlgorithm : ISort
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
        
        var arrayLength = array.Length;

        // Build heap (rearrange array)
        for (var i = arrayLength / 2 - 1; i >= 0; i--)
        {
            Heapify(array, arrayLength, i);
        }

        // One by one extract an element from heap
        for (var i = arrayLength - 1; i > 0; i--)
        {
            ArrayHelper.Swap(array, 0, i);

            // Call max Heapify on the reduced heap
            Heapify(array, i, 0);
        }

        return array;
    }

    // To Heapify a subtree rooted with node i which is
    // an index in array[]. n is size of heap
    private static void Heapify(IList<int> array, int arrayLength, int i)
    {
        var largest = i; // Initialize largest as root
        var left = 2 * i + 1; // left = 2*i + 1
        var right = 2 * i + 2; // right = 2*i + 2

        // If left child is larger than root
        if (left < arrayLength && array[left] > array[largest])
        {
            largest = left;
        }

        // If right child is larger than largest so far
        if (right < arrayLength && array[right] > array[largest])
        {
            largest = right;
        }

        // If largest is not root
        if (largest == i)
        {
            return;
        }
        
        ArrayHelper.Swap(array, i, largest);

        // Recursively Heapify the affected sub-tree
        Heapify(array, arrayLength, largest);
    }
}