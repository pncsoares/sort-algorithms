namespace SortAlgorithms.Helpers;

public static class ArrayHelper
{
    public static void Swap(IList<int> array, int indexOne, int indexTwo)
    {
        if (indexOne > array.Count || indexTwo > array.Count)
        {
            return;
        }
        
        (array[indexOne], array[indexTwo]) = (array[indexTwo], array[indexOne]);
    }
}