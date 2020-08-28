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



        static void QuickSort(ref int[] data, int leftSide, int rightSide)
        {
            if (leftSide < rightSide)
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
            int left = start - 1;
            int right = end + 1;
            while (true)
            {
                //move left until you find a value larger than the pivot
                do
                {
                    left++;
                } while (data[left] < pivot);
                //once its found, check right side
                do
                {
                    right--;
                } while (data[right] > pivot);

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
            Random numGen = new Random();
            int[] exampleArray = new int[numGen.Next(4, 101)];
            for (int i = 0; i < exampleArray.Length; i++)
            {
                exampleArray[i] = numGen.Next(100);
            }
            ;
            QuickSort(ref exampleArray, 0, exampleArray.Length - 1);

            ;
        }
    }
}
