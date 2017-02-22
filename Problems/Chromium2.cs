// -----------------------------------------------------------------------
// <copyright file="Chromium.cs" company="">
// TODO: Update copyright text.
// </copyright>
// -----------------------------------------------------------------------

namespace Problems
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    /// <summary>
    /// TODO: Update summary.
    /// </summary>
    public class Chromium2
    {
        public class Solution
        {
            public int solution(int[] H)
            {
                long combinationCounts = 0;
                long arrLenght = (long)H.Length;
                //int CurrentNumber = 0;
                List<long> leftSide;
                List<long> rightSide;
                for (long pointer = 0; pointer < arrLenght; pointer++)
                {
                    //CurrentNumber = H[pointer];
                    leftSide = SubArray(H, 0, (int)pointer).Where(r => r >= H[pointer]).ToList();
                    leftSide = leftSide.Where(r => r >= H[pointer]).ToArray().ToList(); // removing numbers which are smaller than current number

                    rightSide = SubArray(H, pointer + 1, arrLenght - (pointer + 1));
                    rightSide = rightSide.Where(r => r >= H[pointer]).ToList();         // removing numbers which are smaller than current number

                    combinationCounts = combinationCounts + 1;
                    if (leftSide.Count() == 0 && rightSide.Count() == 0)      // 0/0
                    {
                        // no combination
                    }
                    else if (leftSide.Count() == 0 && rightSide.Count() > 0)  // 0/n
                    {
                        combinationCounts = combinationCounts + rightSide.Count();
                    }
                    else if (leftSide.Count() > 0 && rightSide.Count() == 0)  // n/0
                    {
                        combinationCounts = combinationCounts + leftSide.Count();
                    }
                    else if (leftSide.Count() == 1 && rightSide.Count() == 1)  // 1/1
                    {
                        combinationCounts = combinationCounts + 3;
                    }
                    else // n/n
                    {
                        leftSide.Sort();
                        rightSide.Sort();
                        combinationCounts = combinationCounts + GetCombination(leftSide, rightSide);
                    }
                }
                return (int)combinationCounts;
            }

            public List<long> SubArray(int[] data, long index, long length)
            {
                long[] result = new long[length];
                Array.Copy(data, index, result, 0, length);
                return result.ToList();
            }

            public static long GetCombination(List<long> leftSide, List<long> rightSide)
            {
                int TotalCombinations = 0;
                //List<long> Combined = new List<long>();
                //Combined.AddRange(leftSide);
                //Combined.AddRange(rightSide);
                //Combined.Sort();
                List<string> combinations = new List<string>();
                //long CurrentNumber = 0;
                string longestCombination = string.Empty;
                for (int x = 0; x < leftSide.Count(); x++)
                {
                    longestCombination = string.Empty;
                    longestCombination = FindCombinations(leftSide, rightSide, combinations, x, longestCombination);
                    if(!string.IsNullOrEmpty(longestCombination))
                    combinations.Add(longestCombination);
                }
                for (int x = 0; x < rightSide.Count(); x++)
                {
                    longestCombination = string.Empty;
                    longestCombination = FindCombinations(rightSide, leftSide, combinations, x, longestCombination);
                    if (!string.IsNullOrEmpty(longestCombination))
                        combinations.Add(FindCombinations(rightSide, leftSide, combinations, x, longestCombination));
                }

                TotalCombinations = TotalCombinations + 1;
                combinations.Clear();


                return TotalCombinations;
            }

            private static string FindCombinations(List<long> leftSide, List<long> rightSide, List<string> combinations, int x,string LongestCombination)
            {

                long nextGreaterNum = (from objresult in rightSide where (long)objresult > leftSide[x] select objresult).FirstOrDefault();
                if (nextGreaterNum > 0)
                {

                    LongestCombination = LongestCombination + leftSide[x].ToString() + "," + nextGreaterNum.ToString();
                    x = x + 1;
                    if (leftSide.Count() > x)
                        LongestCombination = FindCombinations(leftSide, rightSide, combinations, x, LongestCombination);
                }
                else if(!string.IsNullOrEmpty(LongestCombination))
                {
                    LongestCombination = LongestCombination + "," + leftSide[x].ToString();
                }
                return LongestCombination;
            }
        }
    }
}
