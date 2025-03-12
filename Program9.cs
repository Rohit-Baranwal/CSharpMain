using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WorkDev
{
    class Program9
    {
        //Given an array nums sorted in non-decreasing order, 
        //    return the maximum between the number of positive integers and the number of negative integers.

        //In other words, 
        //if the number of positive integers in nums is pos and the number of negative integers is neg, then return the maximum of pos and neg.
        //Note that 0 is neither positive nor negative.

        /// <summary>
        /// Maximum Count of Positive Integer and Negative Integer
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public int MaximumCount(int[] nums)
        {
            int negativecount = 0;
            int positiveCount = nums.Length;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] < 0)
                    negativecount++;
                else if (nums[i] == 0)
                    positiveCount--;
                else
                    break;
            }

            positiveCount -= negativecount;

            return Math.Max(positiveCount, negativecount); 
        }
    }
}
