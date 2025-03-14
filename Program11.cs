using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WorkDev
{
    class Program11
    {
        //You are given a 0-indexed integer array candies. Each element in the array denotes a pile of candies of size candies[i]. 
        //You can divide each pile into any number of sub piles, but you cannot merge two piles together.
        //You are also given an integer k. You should allocate piles of candies to k children such that each child gets the same number of candies. 
        //Each child can be allocated candies from only one pile of candies and some piles of candies may go unused.
        //Return the maximum number of candies each child can get.

        /// <summary>
        /// Maximum Candies Allocated to K Children
        /// </summary>
        /// <param name="candies"></param>
        /// <param name="k"></param>
        /// <returns></returns>
        public int MaximumCandies(int[] candies, long k)
        {
            int left = 1, right = candies.Max();
            int result = 0;

            while (left <= right)
            {
                int mid = (left + right) / 2;
                long childrenCount = 0;

                foreach (int candy in candies)
                {
                    childrenCount += candy / mid;
                }

                if (childrenCount >= k)
                {
                    result = mid;
                    left = mid + 1;
                }
                else
                {
                    right = mid - 1;
                }
            }

            return result;
        }
    }
}
