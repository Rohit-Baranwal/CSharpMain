using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WorkDev
{
    public class Program5
    {

        //There is a circle of red and blue tiles. You are given an array of integers colors and an integer k. 
        //The color of tile i is represented by colors[i]:
        //colors[i] == 0 means that tile i is red.
        //colors[i] == 1 means that tile i is blue.
        //An alternating group is every k contiguous tiles in the circle with alternating colors 
        //    (each tile in the group except the first and last one has a different color from its left and right tiles).
        //Return the number of alternating groups.
        //Note that since colors represents a circle, the first and the last tiles are considered to be next to each other.

        /// <summary>
        /// Alternating Groups II
        /// </summary>
        /// <param name="colors"></param>
        /// <param name="k"></param>
        /// <returns></returns>
        public static int NumberOfAlternatingGroups(int[] colors, int k)
        {
            int length = colors.Length;
            int ans = 0;
            int alternatesCount = 1;
            int last = colors[0];
            for (int idx = 1; idx < length; idx++)
            {
                if (colors[idx] == last)
                {
                    alternatesCount = 1;
                    last = colors[idx];
                    continue;
                }

                alternatesCount++;
                if (alternatesCount >= k)
                {
                    ans++;
                }
                last = colors[idx];
            }
            for (int idx = 0; idx < k-1; idx++)
            {
                if (colors[idx] == last) break;
                alternatesCount++;
                if (alternatesCount >= k)
                    ans++;
                last = colors[idx];
            }

            return ans;
        }

        static void Main(string[] args)
        { 
            int[] colors = {0,1,0,1,0};
            int k = 3;

            Console.WriteLine(NumberOfAlternatingGroups(colors, k));
            Console.Read();
        }
    }
}
