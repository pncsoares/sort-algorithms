namespace SortAlgorithms.Interfaces;

public interface ISort
{
    /// <summary>
    /// Receives an array, order it and return the array ordered
    /// </summary>
    /// <param name="array"></param>
    /// <returns></returns>
    int[] Sort(int[] array);
}