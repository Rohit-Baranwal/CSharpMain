using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WorkDev
{
    class Program8
    {

        //You are given a 0-indexed integer array nums and an integer pivot. Rearrange nums such that the following conditions are satisfied:
        //Every element less than pivot appears before every element greater than pivot.
        //Every element equal to pivot appears in between the elements less than and greater than pivot.
        //The relative order of the elements less than pivot and the elements greater than pivot is maintained.
        //More formally, consider every pi, pj where pi is the new position of the ith element and pj is the new position of the jth element. 
        //    If i < j and both elements are smaller (or larger) than pivot, then pi < pj.
        //Return nums after the rearrangement.

        /// <summary>
        /// Partition Array According to Given Pivot
        /// </summary>
        /// <param name="nums"></param>
        /// <param name="pivot"></param>
        /// <returns></returns>
        public int[] PivotArray(int[] nums, int pivot)
        {
            List<int> list1 = new List<int>();
            List<int> list2 = new List<int>();
            int count = 0;
            // Separate elements into three categories
            foreach (int num in nums)
            {
                if (num < pivot)
                    list1.Add(num);
                else if (num == pivot)
                    count++;
                else
                    list2.Add(num);
            }

            int[] ans = new int[nums.Length];
            int index = 0;

            // Add elements smaller than pivot
            foreach (int num in list1)
            {
                ans[index++] = num;
            }

            // Add pivot elements
            for (int i = 0; i < count; i++)
            {
                ans[index++] = pivot;
            }

            // Add elements greater than pivot
            foreach (int num in list2)
            {
                ans[index++] = num;
            }

            return ans;
        }
    }
}
