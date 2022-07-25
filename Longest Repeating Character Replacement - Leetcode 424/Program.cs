using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Longest_Repeating_Character_Replacement___Leetcode_424
{
    internal class Program
    {
        //https://leetcode.com/problems/longest-repeating-character-replacement/
        static void Main(string[] args)
        {
            var input = "AACBABBA";
            var output = CharacterReplacement(input, 2);
            Console.WriteLine(output);
        }

        public static int CharacterReplacement(string s, int k)
        {
            int maxLen = 0;
            int start = 0;
            int maxCount = 0;
            int[] counts = new int[26];

            for (int end = 0; end < s.Length; end++)
            {
                counts[s[end] - 'A']++;
                maxCount = Math.Max(maxCount, counts[s[end] - 'A']);

                //to get window length (end - start + 1)
                // to find max number of replacement which is less than k
                //if maxcount is there
                if (end - start + 1 - maxCount > k)
                {
                    counts[s[start] - 'A']--;
                    start++;
                }
                maxLen = Math.Max(maxLen, end - start + 1);
            }
            return maxLen;

        }

    }
}
