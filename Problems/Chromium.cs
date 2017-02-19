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
                int combinationCounts = 0;
                int arrLenght = H.Length;
                //int CurrentNumber = 0;
                List<int> leftSide;
                List<int> rightSide;
                for (int pointer = 0; pointer < arrLenght; pointer++)
                {
                    //CurrentNumber = H[pointer];
                    leftSide = SubArray(H, 0, pointer).Where(r => r >= H[pointer]).ToList();
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
                        // find length of max side
                        int maxCombinations = 0;
                        if (leftSide.Count() > rightSide.Count())
                            maxCombinations = leftSide.Count();
                        else if (rightSide.Count() > leftSide.Count())
                            maxCombinations = rightSide.Count();
                        else
                            maxCombinations = leftSide.Count(); // both sides are equal in length

                        int maxDigitsCount = (rightSide.Count() + leftSide.Count());
                        
                        StringBuilder strCombinations = new StringBuilder();
                        for (int x = 2; x <= maxDigitsCount; x++)
                        {
                            for (int y = 0; y < maxCombinations; y++)
                            {
                                if (leftSide.Count() > y && rightSide.Count() > y && y < x && leftSide[y] < rightSide[y])
                                {
                                    strCombinations.Append(leftSide[y].ToString() + "," + rightSide[y].ToString() + ":");
                                }
                                if (leftSide.Count() > y && rightSide.Count() > y && y < x && leftSide[y] > rightSide[y])
                                {
                                    strCombinations.Append(rightSide[y].ToString() + "," + leftSide[y].ToString() + ":");
                                }
                            }
                        }

                        combinationCounts = combinationCounts + GetCombination(leftSide, rightSide);
                    }
                }
                return combinationCounts;
            }

            public List<int> SubArray(int[] data, int index, int length)
            {
                int[] result = new int[length];
                Array.Copy(data, index, result, 0, length);
                return result.ToList();
            }

            public static int GetCombination(List<int> leftSide, List<int> rightSide)
            {
                #region // EXTRA
                //string dd = string.Empty;
                //List<string> lstCombinations = new List<string>();
                #endregion

                int TotalCombinations = 0;
                List<int> Combined = new List<int>();
                Combined.AddRange(leftSide);
                Combined.AddRange(rightSide);
                Combined.Sort();
                List<int> combinations = new List<int>();
                double count = Math.Pow(2, Combined.Count);
                for (int i = 1; i <= count - 1; i++)
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
                    /*
                    // if all members are from 1 side than ignore
                    // if length is greater than length of dominant side that ignore
                    // ignore if ratio of elements from both sides is greater than 2
                    bool isAllfromLeftSide = false;
                    bool isAllfromRightSide = false;
                    int LeftRatio = 0;
                    int rightRatio = 0;
                    if (combinations.Count() > 1)
                    {

                        int leftSideElementsCount = leftSide.Intersect(combinations).Count();
                        int rightSideElementsCount = rightSide.Intersect(combinations).Count();
                        LeftRatio = leftSideElementsCount - rightSideElementsCount;
                        rightRatio = rightSideElementsCount - leftSideElementsCount;

                        isAllfromLeftSide = leftSideElementsCount == combinations.Count(); //checks that all element from 1 side
                        isAllfromRightSide = rightSideElementsCount == combinations.Count(); //checks that all element from 1 side
                    }
                    if ((isAllfromLeftSide == false && isAllfromRightSide == false) && (LeftRatio < 2 && rightRatio < 2))
                    {
                        #region EXTRA
                        //lstCombinations.Add(string.Join(",", combinations.ToArray()));
                        //dd = dd + string.Join(",", combinations.ToArray());
                        //dd = dd + ":";
                        #endregion
                        TotalCombinations = TotalCombinations + 1;
                    }*/
                    TotalCombinations = TotalCombinations + 1;
                    combinations.Clear();
                }

                return TotalCombinations;
            }
        }
    }
}
