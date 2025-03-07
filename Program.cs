using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WorkDev
{
    class Program
    {
        //Problem:  Find Missing and Repeated Values
        //You are given a 0-indexed 2D integer matrix grid of size n * n with values in the range [1, n2]. Each integer 
        //appears exactly once except a which appears twice and b which is missing. The task is to find the repeating and missing numbers a and b.
        //Return a 0-indexed integer array ans of size 2 where ans[0] equals to a and ans[1] equals to b.

        /// <summary>
        ///  Find Missing and Repeated Values
        /// </summary>
        /// <param name="grid"></param>
        /// <returns></returns>
        public static int[] FindMissingAndRepeatedValues(int[][] grid) 
        {
            int n = grid.Length * grid.Length + 1;
            bool[] nums = new bool[n];
            int missingNo = 0;
            int repeatNo = 0;

            foreach(int[] arr in grid)
            {
                foreach (int num in arr)
                {
                    if (nums[num]) 
                        repeatNo = num;
                    nums[num] = true;
                }
            }

            for (int i = 0; i < n; i++)
            {
                if (!nums[i])
                    missingNo = i;
            }
                return (new int[]{repeatNo, missingNo});
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            int[][] grid = { new int[] { 1, 3 }, new int[] { 2, 2 } };

            int[] ans = FindMissingAndRepeatedValues(grid);

            foreach (int item in ans)
            {
                Console.Write(item + "  ");
            }

            Console.Read();
        }
    }
}
