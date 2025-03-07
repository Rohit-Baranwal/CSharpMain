using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WorkDev
{
    class Program3
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="arr"></param>
        /// <returns></returns>
        public static int NumOfSubarrays(int[] arr)
        {
            int mod = (int)(1e9 + 7);
            int ans = 0;
            int pfSum = 0;
            int oddSum = 0;
            int evenSum = 1;

            foreach (int num in arr)
            {
                pfSum += num;
                if ((pfSum & 1) == 0)
                {
                    evenSum++;
                    ans += oddSum;
                }
                else
                {
                    oddSum++;
                    ans += evenSum;
                }
                ans %= mod;
            }

            return ans;
        }

        static void Main(string[] args)
        {
            int[] arr = new int[] { 1, 3, 5 };

            Console.WriteLine(NumOfSubarrays(arr));
            Console.Read();
        }
    }
}
