using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WorkDev
{
    class Program4
    {
        //You are given a 0-indexed string blocks of length n, where blocks[i] is either 'W' or 'B', 
        //representing the color of the ith block. The characters 'W' and 'B' denote the colors white and black, respectively.
        //You are also given an integer k, which is the desired number of consecutive black blocks.
        //In one operation, you can recolor a white block such that it becomes a black block.
        //Return the minimum number of operations needed such that there is at least one occurrence of k consecutive black blocks.

        /// <summary>
        /// Minimum Recolors to Get K Consecutive Black Blocks
        /// </summary>
        /// <param name="blocks"></param>
        /// <param name="k"></param>
        /// <returns></returns>
        public static int MinimumRecolors(string blocks, int k)
        {
            int numOfWhite = 0;
            int ans = Int32.MaxValue;

            for (int i = 0; i < k; i++)
            {
                char ch = blocks[i];
                if (ch == 'W')
                    numOfWhite++;
            }

            ans = numOfWhite;
            int left = 0;
            for (int right = k; right < blocks.Length; right++, left++)
            {
                char ch = blocks[right];
                if (ch == 'W')
                {
                    numOfWhite++;
                }
                if (blocks[left] == 'W')
                {
                    numOfWhite--;
                }
                ans = Math.Min(ans, numOfWhite);
            }

            return ans;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            string blocks = "WBBWWBBWBW";
            int k = 7;
            Console.WriteLine(MinimumRecolors(blocks, k));
            Console.Read();
        }
    }
}
