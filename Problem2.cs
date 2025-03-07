using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WorkDev
{
    class Problem2
    {

        //Given two positive integers left and right, find the two integers num1 and num2 such that:
        //left <= num1 < num2 <= right .
        //Both num1 and num2 are prime numbers.
        //num2 - num1 is the minimum amongst all other pairs satisfying the above conditions.
        //Return the positive integer array ans = [num1, num2]. 
        //If there are multiple pairs satisfying these conditions, 
        //    return the one with the smallest num1 value. If no such numbers exist, return [-1, -1].

        /// <summary>
        /// Closest Prime Numbers in Range
        /// </summary>
        /// <param name="left"></param>
        /// <param name="right"></param>
        /// <returns></returns>
        public static int[] ClosestPrimes(int left, int right)
        {
            bool[] sieve = generateSieve(right);
            List<int> primes = new List<int>();
            for (int num = left; num <= right; num++)
            {
                if (sieve[num])
                {
                    primes.Add(num);
                }
            }

            if(primes.Count < 2)
                return (new int[]{-1,-1});

            int minDiff = Int32.MaxValue;
            int[] pair = new int[2];

            for (int i = 1; i < primes.Count; i++)
            {
                int diff = primes[i] - primes[i - 1];
                if (diff < minDiff)
                {
                    minDiff = diff;
                    pair[0] = primes[i - 1];
                    pair[1] = primes[i];
                }
            }

            return pair;
        }

        /// <summary>
        /// Find the range of bool arrays
        /// </summary>
        /// <param name="max"></param>
        /// <returns></returns>
        public static bool[] generateSieve(int max)
        {
            bool[] sieve = new bool[max + 1];
            sieve[0] = false;
            sieve[1] = false;
            for (int i = 2; i < sieve.Length; i++)
            {
                sieve[i] = true;
            }
            for (int i = 2; i * i <= max; i++)
            {
                if (sieve[i])
                {
                    for (int j = i * i; j <= max; j += i)
                    {
                        sieve[j] = false;
                    }
                }
            }
            return sieve;
        }

        static void Main(string[] args)
        {
            int left = 10, right = 19;
            int[] ans = ClosestPrimes(left, right);

            foreach (int item in ans)
            {
                Console.Write(item + "  ");
            }
            Console.Read();
        }
    }
}
