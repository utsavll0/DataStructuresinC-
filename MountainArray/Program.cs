using System;

namespace MountainArray
{
    class Program
    {
        public static bool ValidMountainArray(int[] A) 
        {
            if(A.Length == 0)
            {
                return false;
            }
            int breakPoint = 0;
            int i = 0;
            while(i < A.Length - 1)
            {
                if(A[i+1] <= A[i])
                {
                    breakPoint = i;
                    break;
                }
                i++;
            }
            if(breakPoint == 0)
            {
                return false;
            }
            for(int j=breakPoint;j<A.Length-1;j++)
            {
                if(A[j+1]>=A[j])
                {
                    return false;
                }
            }
            return true;
        }
        static void Main(string[] args)
        {
            int[] arr = {1,2,3,4,5,4,3};
            bool value = ValidMountainArray(arr);
        }
    }
}
