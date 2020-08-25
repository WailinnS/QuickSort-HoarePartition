using System;
using System.Diagnostics.Tracing;
using System.Threading;

namespace QuickSort_HoarePartition
{
    class Program
    {
        static void Swap(ref int left, ref int right)
        {
            int temp = left;
            left = right;
            right = temp;
        }



        static void QuickSort(ref int[] data, int leftSide, int rightSide)
        {
            while (leftSide < rightSide)
            {
                int pivot = HoarePartition(ref data, leftSide, rightSide);
                //left side
                QuickSort(ref data, leftSide, pivot);
                //rightSide
                QuickSort(ref data, pivot + 1, rightSide);
            }

        }
        //thio should return a pivot, needs to be improved...
        static int HoarePartition(ref int[] data, int start, int end)
        {
            int pivot = data[start];
            int left = start + 1;
            int right = end - 1;
            while (true)
            {
                //move left until you find a value larger than the pivot
                while (data[left] <= pivot)
                {
                    left++;
                }
                //once its found, check right side
                while (data[right] > pivot)
                {
                    right--;
                }
                
                if (left >= right)
                {
                    return right;
                }

                Swap(ref data[left], ref data[right]);
            }
          

        }

        static void Main(string[] args)
        {
            //quickSort Hoare Partition
            int[] exampleArray = new int[] { 50, 44, 33, 62, 20, 11, 72 };

            QuickSort(ref exampleArray, 0, exampleArray.Length - 1);


        }
    }
}
