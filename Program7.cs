using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WorkDev
{
    class Program7
    {
        //Given a string s consisting only of characters a, b and c.
        //Return the number of substrings containing at least one occurrence of all these characters a, b and c.

        /// <summary>
        /// Number of Substrings Containing All Three Characters
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public int NumberOfSubstrings(string s)
        {
            Dictionary<char, int> hm = new Dictionary<char, int>();
            int ans = 0;
            int left = 0, right = 0;

            while (right < s.Length)
            {
                char ch = s[right];
                if (!hm.ContainsKey(ch))
                    hm[ch] = 0;
                hm[ch]++;

                while (hm.Count == 3)
                {
                    ans += s.Length - right;
                    char leftChar = s[left];
                    hm[leftChar]--;
                    if (hm[leftChar] == 0)
                        hm.Remove(leftChar);
                    left++;
                }
                right++;
            }

            return ans;
        }
    }
}
