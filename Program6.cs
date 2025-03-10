using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WorkDev
{
    class Program6
    {
        //You are given a string word and a non-negative integer k.
        //Return the total number of substrings of word that contain every vowel ('a', 'e', 'i', 'o', and 'u') 
        //at least once and exactly k consonants.

        /// <summary>
        /// Count of Substrings Containing Every Vowel and K Consonants II
        /// </summary>
        /// <param name="word"></param>
        /// <param name="k"></param>
        /// <returns></returns>
        public long CountOfSubstrings(string word, int k)
        {
            int[,] frequencies = new int[2, 128];
            foreach (char vowel in "aeiou")
                frequencies[0, vowel] = 1;

            long response = 0;
            int currentK = 0, vowels = 0, extraLeft = 0;

            for (int right = 0, left = 0; right < word.Length; right++)
            {
                char rightChar = word[right];

                if (frequencies[0, rightChar] == 1)
                {
                    if (++frequencies[1, rightChar] == 1) vowels++;
                }
                else
                {
                    currentK++;
                }

                while (currentK > k)
                {
                    char leftChar = word[left];
                    if (frequencies[0, leftChar] == 1)
                    {
                        if (--frequencies[1, leftChar] == 0) vowels--;
                    }
                    else
                    {
                        currentK--;
                    }
                    left++;
                    extraLeft = 0;
                }

                while (vowels == 5 && currentK == k && left < right && frequencies[0, word[left]] == 1 && frequencies[1, word[left]] > 1)
                {
                    extraLeft++;
                    frequencies[1, word[left]]--;
                    left++;
                }

                if (currentK == k && vowels == 5)
                {
                    response += (1 + extraLeft);
                }
            }

            return response;
        }
    }
}
