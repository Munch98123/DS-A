using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.Algorithms
{
    public class QuickSort
    {
        static public void Swap(int[] arr, int i, int j)
        {
            int temp = arr[i];
            arr[i] = arr[j];
            arr[j] = temp;
        }

        static public int PartitionArray(int[] arr, int low, int high) 
        {
            //pivot last element
            int pivot = arr[high];
            //index of current element 
            int i = low - 1;
            //iterate through all elements swapping as needed
            for(int j = low;j <= high - 1; j++)
            {
                //if we come across a value smaller than pivot, increment pointer and swap 
                if (arr[j] < pivot)
                {
                    i++;
                    Swap(arr, i, j);
                }
            }
            //swap current pointer index and last element, puts pivot in correct spot
            Swap(arr, i + 1, high);
            return(i + 1);  
        }

        static public void QS(int[] arr, int low, int high)
        {
            if(low < high)
            {
                int pivot = PartitionArray(arr, low, high);

                QS(arr, low, pivot-1);
                QS(arr, pivot+1, high);
            }
        }
    }
}
