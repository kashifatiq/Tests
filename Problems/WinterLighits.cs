using System;
using System.Collections.Generic;
using System.Linq;

/*https://codility.com/cert/view/certZ9S98N-S3B2FJD9U43Z8NUK/*/
//https://codility.com/cert/view/cert85QKEE-434GXX526NTFS2CC/

namespace Problems
{
           
    public class WinterLighits
    {
        //using System;
        //using System.Collections.Generic;
        //using System.Linq;
        public class Solution
        {
            //List<string> lstexecTimes = new List<string>();
            
            public int solution(string S)
            {
                try
                {
                    //lstexecTimes = new List<string>();
                    int segmentsCount = 0;
                    segmentsCount = GetCombinations(S);
                    segmentsCount = segmentsCount + S.Length;

                    return segmentsCount;
                }
                finally
                {
                    GC.Collect();
                }
            }

            private bool canFormPalindrome(string str)
            {
                //var watch = System.Diagnostics.Stopwatch.StartNew();
                int NO_OF_CHARS = 256;
                // Create a count array and initialize all values as 0
                int[] count = new int[NO_OF_CHARS];
                // For each character in input strings, increment count in the corresponding count array
                for (int x = 0; x < str.Length; x++)
                {
                    
                }
                foreach (char t in str)
                {
                   count[t]++;
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
                //watch.Stop();
                //var elapsedMs = watch.ElapsedMilliseconds;
                //lstexecTimes.Add("canform :" + elapsedMs.ToString());                
                return (odd <= 1);
            }

            private int GetCombinations(string S)
            {
                try
                {
                    int palindromsCount = 0;
                    //List<string> lstCombinations = new List<string>();
                    //Dictionary<string, bool> dicAlreadyTested = new Dictionary<string, bool>();
                    int pairSize = 2; //starting from pairs of 2 ignoring single letters
                    int pairSegments = S.Length - 1;
                    while (pairSegments > 0)
                    {
                        int counter = 0;
                        while (counter < pairSegments)
                        {
                            string pair = S.Substring(counter, pairSize);
                            //if (dicAlreadyTested.ContainsKey(pair))
                            //{
                            //    bool isPalindrome = dicAlreadyTested[pair];
                            //    if (isPalindrome == true)
                            //        palindromsCount = palindromsCount + 1;
                            //}
                            //else
                            //{
                            if (IsPalindrom(pair))
                            {
                                palindromsCount = palindromsCount + 1;
                                //dicAlreadyTested.Add(pair, true);
                                //lstCombinations.Add(pair);
                            }
                            else if (pair.Length > 2)
                            {
                                if (canFormPalindrome(pair))
                                {
                                    //dicAlreadyTested.Add(pair, true);
                                    palindromsCount = palindromsCount + 1;
                                    //lstCombinations.Add(pair);
                                }
                                /*  else // can not create palindrome
                                  {
                                      dicAlreadyTested.Add(pair, false);
                                  }
                              }*/
                            }
                            counter = counter + 1;
                        }
                        pairSegments = pairSegments - 1;
                        pairSize = pairSize + 1;
                    }
                    //return lstCombinations.Count();
                    return palindromsCount;
                }
                finally
                {
                    GC.Collect();
                }
            }

            private static bool IsPalindrom(string stringToCheck)
            {
                var isEqual = stringToCheck.SequenceEqual(stringToCheck.Reverse());
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