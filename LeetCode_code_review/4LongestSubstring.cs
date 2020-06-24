using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_code_review
{
    //https://leetcode.com/problems/longest-substring-without-repeating-characters/
    public class _4LongestSubstring
    {
        public class Solution
        {

            private StringBuilder builder;

            public int LengthOfLongestSubstring(string s)
            {
                builder = new StringBuilder();
                string LSWRC = lengthOfLongestS(s, "", 0, new HashSet<char>());
                return LSWRC.Length;
            }

            private string lengthOfLongestS(string s, string soFar, int position, HashSet<char> usedCaracters)
            {
                if (position == s.Length)
                {
                    return soFar;
                }
                string dontSkipCaracter = "";
                if (!usedCaracters.Contains(s[position]))
                {
                    soFar += s[position];
                    usedCaracters.Add(s[position]);
                    string stringContinue = lengthOfLongestS(s, soFar, position + 1, usedCaracters);
                    dontSkipCaracter = soFar.Length > stringContinue.Length ? soFar : stringContinue;
                    usedCaracters.Remove(s[position]);
                }
                string skipCaracter = lengthOfLongestS(s, "", position + 1, new HashSet<char>());
                return skipCaracter.Length > dontSkipCaracter.Length ? skipCaracter : dontSkipCaracter;

            }
        }
    }
}
