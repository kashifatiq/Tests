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
    public class Chromium
    {
        public class Solution
        {
            public int solution(int[] H)
            {
                long combinationCounts = 0;
                long arrLenght =(long)H.Length;
                //int CurrentNumber = 0;
                List<long> leftSide;
                List<long> rightSide;
                for (long pointer = 0; pointer < arrLenght; pointer++)
                {
                    //CurrentNumber = H[pointer];
                    leftSide = SubArray(H, 0,(int)pointer).Where(r => r >= H[pointer]).ToList();
                    leftSide = leftSide.Where(r => r >= H[pointer]).ToArray().ToList();
                    leftSide.Sort();

                    rightSide = SubArray(H, pointer + 1, arrLenght - (pointer + 1));
                    rightSide = rightSide.Where(r => r >= H[pointer]).ToList();
                    rightSide.Sort();

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
                List<long> Combined = new List<long>();
                Combined.AddRange(leftSide);
                Combined.AddRange(rightSide);
                Combined.Sort();
                List<long> combinations = new List<long>();
                double count = Math.Pow(2, Combined.Count);
                for (long i = 1; i <= count - 1; i++)
                {
                    string str = Convert.ToString(i, 2).PadLeft(Combined.Count, '0');
                    for (int j = 0; j < str.Length; j++)
                    {
                        if (str[j] == '1')
                        {
                            combinations.Add(Combined[j]);
                            if (combinations.Count() >= 2)
                            {
                                // if there are consecutive elements from any 1 list than ignore this combination
                                if (leftSide.Contains(combinations[combinations.Count() -1]) == true && leftSide.Contains(combinations[combinations.Count() - 2]) == true)
                                {
                                    combinations.Clear();
                                    break;
                                }
                                if (rightSide.Contains(combinations[combinations.Count() - 1]) == true && rightSide.Contains(combinations[combinations.Count() - 2]) == true)
                                {
                                    combinations.Clear();
                                    break;
                                }
                            }
                        }
                    }
                    if (combinations.Count() == 0)
                        continue;
                    TotalCombinations = TotalCombinations + 1;
                    combinations.Clear();
                }

                return TotalCombinations;
            }
        }
    }
}
