using System;

namespace ThirdMaxNumber
{
    class Program
    {
        public static int ThirdMax(int[] nums) 
        {
            int max = nums[0];
            int secondMax = 0;
            int thirdMax = 0;
            bool thirdMaxFound = false;
            bool secondMaxFound = false;
            int k=0;
            while(k<nums.Length)
            {
                if(max != nums[k])
                {
                    secondMax = nums[k];
                    secondMaxFound = true;
                    break;
                }
                k++;
            }
            while(k<nums.Length)
            {
                if(secondMax != nums[k] && nums[k] != max)
                {
                    thirdMax = nums[k];
                    thirdMaxFound = true;
                    break;
                }
                k++;
            }
            if(secondMaxFound == false)
            {
                return max;
            }
            if(thirdMaxFound == false)
            {
                return Math.Max(max,secondMax);
            }
            for(int i = 0; i < nums.Length; i++)
            {
                if(nums[i] > max)
                {
                    int temp = max;
                    int temp1 = secondMax;
                    max = nums[i];
                    secondMax = temp;
                    if(max != temp1)
                        thirdMax = temp1;
                }
                else if(nums[i] < max && nums[i] > secondMax)
                {
                    int temp = secondMax;
                    secondMax = nums[i];
                    thirdMax = temp;
                }
                else if(nums[i] < secondMax && nums[i] > thirdMax)
                {
                    if(nums[i] != secondMax && nums[i] != max)
                        thirdMax = nums[i];
                }
            }
            return thirdMax;
        }
        static void Main(string[] args)
        {
            int[] arr = {3,3,3,3,4,3,3,3,3};
            int ans = ThirdMax(arr);
        }
    }
}
