using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickSort
{
    #region assignment specs
    /* algorithm for quicksort
     * 
     * quicksort method:
     * algorithm quicksort (A, lo, hi) is
     * if lo < hi then
     * p = partition(A, lo, hi)
     * quicksort(A, lo, p)
     * quicksort(A, p+1, hi)
     * 
     * partition method:
     * algorithm partition(A, lo, hi) is
     * pivot = A[lo + (hi - lo) / 2]
     * i = lo - 1
     * j = hi + 1
     * 
     * sorting process:
     * loop forever
     * do
     *      i = i + 1
     * while A[i] < pivot
     * do
     *      j = j -1
     * while A[j] > pivot
     * if i >= j then
     *      return j
     * swap A[i] with A[j]
     */
    #endregion

    class Program
    {
        static void Main(string[] args)
        {
            // declare and initialize array
            Console.WriteLine("*** PROGRAM QUICKSORT ***\n\n");
            int[] intArray = new int[] { 80, 77, 25, 32, 19, 66, 22, 21, 34, 56 };
            int arrayLength = intArray.Length;
            Console.WriteLine("=> Unsorted Array:");
            foreach (int element in intArray)
            {
                Console.Write(element+" ");
            }
            Console.WriteLine("\n\n");

            QuickSort(intArray, 0, arrayLength-1);
            Console.WriteLine("=> Sorted Array:");
            foreach (int element in intArray)
            {
                Console.Write(element + " ");
            }
            Console.WriteLine("\n\n");

            // number of swaps
            Count.PrintCount();
        }

        static void QuickSort(int[] arr, int lo, int hi)
        {
            if (lo < hi)
            {
                // partitioning index
                int partIndex = Partition(arr, lo, hi);

                // recursively sort elements before and after partition
                QuickSort(arr, lo, partIndex);
                QuickSort(arr, partIndex + 1, hi);
            }
        }

        static int Partition(int[] arr, int lo, int hi)
        {
            // pivot element (median)
            int pivot = arr[lo + (hi - lo) / 2];
            // index of smaller element
            int i = lo - 1;
            // index of greater element
            int j = hi + 1;

            // loop constructs
            while (true)
            {
                do
                {
                    i = i + 1;
                }
                while (arr[i] < pivot);

                do
                {
                    j = j - 1;
                }
                while (arr[j] > pivot);

                if (i >= j)
                {
                    return j;
                }
                int temp = arr[i];
                arr[i] = arr[j];
                arr[j] = temp;
                // swap counter
                Count.count++;
            }
        }
    }
}
