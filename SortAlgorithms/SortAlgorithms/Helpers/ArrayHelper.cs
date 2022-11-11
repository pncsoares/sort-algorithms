namespace SortAlgorithms.Helpers;

public static class ArrayHelper
{
    public static void Swap(IList<int> array, int indexOne, int indexTwo) =>
        (array[indexOne], array[indexTwo]) = (array[indexTwo], array[indexOne]);
}