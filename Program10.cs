using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WorkDev
{
    class Program10
    {
        //You are given an integer array nums of length n and a 2D array queries where queries[i] = [li, ri, vali].

        //Each queries[i] represents the following action on nums:

        //Decrement the value at each index in the range [li, ri] in nums by at most vali.
        //The amount by which each value is decremented can be chosen independently for each index.
        //A Zero Array is an array with all its elements equal to 0.

        //Return the minimum possible non-negative value of k, such that after processing the first k queries in sequence, nums becomes a Zero Array. 
        //    If no such k exists, return -1.


        /// <summary>
        /// Zero Array Transformation II
        /// </summary>
        /// <param name="nums"></param>
        /// <param name="queries"></param>
        /// <returns></returns>
        public int MinZeroArray(int[] nums, int[][] queries)
        {
            int n = nums.Length;
            int q = queries.Length;

            int[] diff = new int[n + 1]; // Difference array to track updates

            for (int i = 0; i < q; i++)
            {
                int l = queries[i][0], r = queries[i][1], val = queries[i][2];

                // Apply the range decrement in the difference array
                diff[l] -= val;
                if (r + 1 < n) diff[r + 1] += val;

                // Apply the difference array to actual nums array
                int sum = 0;
                bool isZero = true;

                for (int j = 0; j < n; j++)
                {
                    sum += diff[j]; // Accumulate difference
                    nums[j] += sum; // Apply accumulated difference
                    if (nums[j] > 0) isZero = false;
                }

                if (isZero) return i + 1; // Return minimum queries required
            }

            return -1; // No such k exists
        }
    }
}
