using System;

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

        static void QuickSort(ref int[] data)
        {

            //get pivot
            int pivot = data[0];

            //once left and right pass each other or meet, split the array with the right being in left sub array
            QuickSort(ref data, 0, data.Length - 1);
       
        }
        static void QuickSort(ref int[] data ,int start, int end)
        {
            int pivot = data[start];
            int left = start;
            int right = end;
            while (right > left)
            {
                //move left until you find a value larger than the pivot
                while (data[left] < pivot)
                {
                    left++;
                }
                //once its found, check right side
                while (data[right] > pivot)
                {
                    right--;
                }

                Swap(ref data[left], ref data[right]);
                left++;
                right--;
            }
           

        }

        static void Main(string[] args)
        {
            //quickSort Hoare Partition
            int[] exampleArray = new int[] { 5, 4, 3, 6, 2, 1, 7 };




            ;
        }
    }
}
