# Heap Sort

Heap sort is a comparison-based sorting technique based on Binary Heap data structure.

It is similar to the selection sort where we first find the minimum element and place the minimum element at the beginning.

Repeat the same process for the remaining elements.

## Heapify

Heapify is the process of creating a heap data structure from a binary tree represented using an array.

It is used to create Min-Heap or Max-heap. Start from the first index of the non-leaf node whose index is given by n/2 – 1

## How heap sort works?

1. Build a max heap from the input data
2. At this point, the maximum element is stored at the root of the heap. Replace it with the last item of the heap followed by reducing the size of the heap by 1
3. Heapify the root of the tree 
4. Repeat step 2 while the size of the heap is greater than 1

![heap-sort](https://upload.wikimedia.org/wikipedia/commons/f/fe/Heap_sort_example.gif)

# Big-O

$O(n log (n))$