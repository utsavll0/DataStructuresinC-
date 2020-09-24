using System;

namespace DuplicateZeros
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = {1,0,2,3,0,4,5,0};
            for(int i = 0;i<arr.Length;i++)
            {
                if(arr[i]==0)
                {
                    for(int j = arr.Length-1;j>i;j--)
                    {
                        arr[j] = arr[j-1];
                    }
                }
            }
        }
    }
}
