using System;

namespace Sorting
{
    class Program
    {

        static int[] BubbleSort(int[] arr)
        {
            int n = arr.Length;
            for(int i=0;i<n;i++)
            {
                for(int j=0;j<n-1;j++)
                {
                    if(arr[j] > arr[j+1])
                    {
                        int temp = arr[j];
                        arr[j] = arr[j+1];
                        arr[j+1] = temp;
                    }
                }
            }
            return arr;
        }

        
        static int[] SelectionSort(int[] arr)
        {
            int n = arr.Length;
            for(int i=0;i<n;i++)
            {
                int min = arr[i];
                int min_index = i;
                for(int j=i+1;j<n;j++)
                {
                    if(arr[j] < min)
                    {
                        min = arr[j];
                        min_index = j;
                    }
                }
                arr[min_index] = arr[i];
                arr[i] = min;
            }
            return arr;
        }

        static void Main(string[] args)
        {
            int[] arr = {8,5,2,6,9,3,1,4,0,7};
            // int[] bubbleSort = BubbleSort(arr);
            int[] selectionSort = SelectionSort(arr);
        }
    }
}
