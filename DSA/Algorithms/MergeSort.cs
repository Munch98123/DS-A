using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.Algorithms
{
    public class MergeSort
    {
        static public void Merge(int[] arr, int first, int middle, int arrLength)
        {
            //first size is from first element to middle element
            int arrSize1 = middle - first + 1;
            //second size from middle element to last
            int arrSize2 = arrLength - middle;

            int[] left = new int[arrSize1];
            int[] right = new int[arrSize2];
            int i, j;

            for(i = 0; i < arrSize1; i++)
            {
                left[i] = arr[first + i];
            }
            for(j = 0; j < arrSize2; j++)
            {
                right[j] = arr[middle + 1 + j];
            }

            i = 0;
            j = 0;

            int k = first;
            while(i < arrSize1 && j < arrSize2)
            {
                if (left[i] <= right[j])
                {
                    arr[k] = left[i];
                    i++;
                }
                else
                {
                    arr[k] = right[j];
                    j++;
                }
                k++;
            }

            while(i < arrSize1)
            {
                arr[k] = left[i];
                i++;
                k++;
            }

            while(j < arrSize2)
            {
                arr[k] = right[j];
                j++;
                k++;
            }
        }

        static public void Sort(int[] arr, int first, int length)
        {
            //array needs to have more than 1 element
            if(first < length)
            {
                int middle = first + (length - first) / 2;

                Sort(arr, first, middle);
                Sort(arr, middle + 1, length);

                Merge(arr, first, middle, length);
            }
        }
    }
}
