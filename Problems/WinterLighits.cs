using System;
using System.Collections.Generic;
using System.Text;

using System.Linq;

https://codility.com/cert/view/certZ9S98N-S3B2FJD9U43Z8NUK/

namespace Problems
{
    public class WinterLighits
    {
        public class Solution
        {
            public int solution(string S)
            {
                int segmentsCount = 0;
                List<string> allCombinations = GetCombinations(S);
                foreach(string str in allCombinations)
                {
                    if(isPalindrom(str))
                    {
                        segmentsCount = segmentsCount + 1;
                    }
                    else
                    {
                        bool ok = canFormPalindrome(str);
                        if (ok)
                            segmentsCount = segmentsCount + 1;
                    }
                }
                return segmentsCount;
            }

            private bool canFormPalindrome(string str)
            {
                int NO_OF_CHARS = 256;
                // Create a count array and initialize all values as 0
                int[] count = new int[NO_OF_CHARS];

                // For each character in input strings, increment count in
                // the corresponding count array
                for (int i = 0;i<str.Length; i++)
                {
                    count[str[i]]++;
                }

                // Count odd occurring characters
                int odd = 0;
                for (int i = 0; i < NO_OF_CHARS; i++)
                {
                    if ((count[i] & 1) != 0)
                    {
                        odd++;
                    }
                }

                // Return true if odd count is 0 or 1, otherwise false
                return (odd <= 1);
            }

            private List<string> GetCombinations(string S)
            {
                List<string> lstCombinations = new List<string>();
                int PairSize = 1;
                int PairSegments = S.Length;
                while (PairSegments > 0)
                {
                    int counter = 0;
                    while (counter < PairSegments)
                    {
                        string pair = S.Substring(counter, PairSize);
                        lstCombinations.Add(pair);
                        counter = counter + 1;
                    }
                    PairSegments = PairSegments - 1;
                    PairSize = PairSize + 1;
                }
                return lstCombinations;
            }
            private bool isPalindrom(string stringToCheck)
            {
                bool isEqual = false;
                isEqual = stringToCheck.SequenceEqual(stringToCheck.Reverse());
                return isEqual;
            }
        }

        /*
         private static bool IsPossiblePalindrom(string str)
            {
                bool ok = str.GroupBy(c => c).Select(g => g.Count()).Where(c => c == 1).Count() < 2;
                return ok;
            }
         
            private List<string> GetAllCombinations(string str)
            {
                List<string> results = Enumerable.Range(0, 1 << str.Length).Select(e => string.Join(string.Empty, Enumerable.Range(0, str.Length).Select(b => (e & (1 << b)) == 0 ? (char?)null : str[b]))).ToList();
                return results.Where(s => !string.IsNullOrWhiteSpace(s)).ToList();
            }*/
    }
}