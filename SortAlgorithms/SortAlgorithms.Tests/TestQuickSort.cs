using System;
using SortAlgorithms.QuickSort;
using Xunit;

namespace SortAlgorithms.Tests;

public class TestQuickSort
{
    private readonly QuickSortAlgorithm _sut = new(); 
    
    [Fact]
    public void Test_QuickSort_UnorderedArray()
    {
        // Arrange
        var inputArray = new[] { 1, 5, 0, 34, 3, 9 };
        var expectedArray = new[] { 0, 1, 3, 5, 9, 34 };

        // Act
        var outputArray = _sut.Sort(inputArray);

        // Assert
        Assert.Equal(expectedArray, outputArray);
    }
    
    [Fact]
    public void Test_QuickSort_UnorderedArray_WithDuplicates()
    {
        // Arrange
        var inputArray = new[] { 1, 5, 5, 0, 34, 34, 3, 9 };
        var expectedArray = new[] { 0, 1, 3, 5, 5, 9, 34, 34 };

        // Act
        var outputArray = _sut.Sort(inputArray);

        // Assert
        Assert.Equal(expectedArray, outputArray);
    }
    
    [Fact]
    public void Test_QuickSort_OrderedArray()
    {
        // Arrange
        var inputArray = new[] { 0, 1, 3, 5, 9, 34 };
        var expectedArray = new[] { 0, 1, 3, 5, 9, 34 };

        // Act
        var outputArray = _sut.Sort(inputArray);

        // Assert
        Assert.Equal(expectedArray, outputArray);
    }
    
    [Fact]
    public void Test_QuickSort_OrderedArray_WithDuplicates()
    {
        // Arrange
        var inputArray = new[] { 0, 1, 3, 5, 5, 9, 34, 34 };
        var expectedArray = new[] { 0, 1, 3, 5, 5, 9, 34, 34 };

        // Act
        var outputArray = _sut.Sort(inputArray);

        // Assert
        Assert.Equal(expectedArray, outputArray);
    }
    
    [Fact]
    public void Test_QuickSort_EmptyArray()
    {
        // Arrange
        var inputArray = System.Array.Empty<int>();
        var expectedMessage = $"The array must contain at least two elements! The passed array has {inputArray.Length} elements.";

        // Act
        Action act = () => _sut.Sort(inputArray);

        // Assert
        var exception = Assert.Throws<ArgumentException>(act);
        Assert.Equal(expectedMessage, exception.Message);
    }
    
    [Fact]
    public void Test_QuickSort_NullArray()
    {
        // Arrange
        int[] inputArray = null;

        // Act
        Action act = () => _sut.Sort(inputArray);

        // Assert
        Assert.Throws<ArgumentNullException>(act);
    }
}