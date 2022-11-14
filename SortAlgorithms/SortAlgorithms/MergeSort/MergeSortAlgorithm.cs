using SortAlgorithms.Interfaces;

namespace SortAlgorithms.MergeSort;

public class MergeSortAlgorithm : ISort
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
        
        MergeSort(array);

        return array;
    }

    private static void MergeSort(IList<int> array)
    {
        if (array.Count < 2)
        {
            return;
        }

        var midIndex = array.Count / 2;
        var leftHalf = new int[midIndex];
        var rightHalf = new int[array.Count - midIndex];

        // Fill left half array
        for (var i = 0; i < midIndex; i++)
        {
            leftHalf[i] = array[i];
        }
        
        // Fill right half array
        for (var i = midIndex; i < array.Count; i++)
        {
            // We want to fill the right half from index zero
            // But copy from mid index up
            rightHalf[i - midIndex] = array[i];
        }
        
        MergeSort(leftHalf);
        MergeSort(rightHalf);
        
        Merge(array, leftHalf, rightHalf);
    }

    private static void Merge(IList<int> array, IReadOnlyList<int> leftArray, IReadOnlyList<int> rightArray)
    {
        var i = 0;
        var j = 0;
        var k = 0;

        while (i < leftArray.Count && j < rightArray.Count)
        {
            if (leftArray[i] <= rightArray[j])
            {
                array[k] = leftArray[i];
                i++;
            }
            else
            {
                array[k] = rightArray[j];
                j++;
            }

            k++;
        }

        while (i < leftArray.Count)
        {
            array[k] = leftArray[i];
            i++;
            k++;
        }
        
        while (j < rightArray.Count)
        {
            array[k] = rightArray[j];
            j++;
            k++;
        }
    }
}