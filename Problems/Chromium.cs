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
                int CurrentNumber = 0;
                List<int> leftSide;
                List<int> rightSide;
                //List<string> combinations = new List<string>();
                for (int pointer = 0; pointer < arrLenght; pointer++)
                {
                    CurrentNumber = H[pointer];
                    leftSide = SubArray(H, 0, pointer).Where(r => r >= H[pointer]).ToList();
                    leftSide = leftSide.Where(r => r >= H[pointer]).ToArray().ToList();
                    //leftSide.Sort();

                    rightSide = SubArray(H, pointer + 1, arrLenght - (pointer + 1));
                    rightSide = rightSide.Where(r => r >= H[pointer]).ToList();
                    //rightSide.Sort();

                    combinationCounts = combinationCounts + 1;
                    if (leftSide.Count() == 0 && rightSide.Count() == 0)      // 0/0
                    {
                        // no combination
                        //combinationCounts = combinationCounts + 1;
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
                        combinationCounts = combinationCounts + (rightSide.Count() + leftSide.Count()); // single combination with each number 
                        // find length of max side
                        int maxCombinations = 0;
                        if (leftSide.Count() > rightSide.Count())
                            maxCombinations = leftSide.Count();
                        else if (rightSide.Count() > leftSide.Count())
                            maxCombinations = rightSide.Count();
                        else
                            maxCombinations = leftSide.Count(); // both sides are equal in length
                        maxCombinations = (rightSide.Count() + leftSide.Count()) * maxCombinations;

                        int maxDigitsCount = (rightSide.Count() + leftSide.Count());
                        
                        StringBuilder strCombinations = new StringBuilder();
                        for (int x = 2; x <= maxDigitsCount; x++)
                        {
                            int counter = 0;
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

                        List<int> Combined = leftSide;
                        Combined.AddRange(rightSide);
                        GetCombination(Combined, 1);
                        //IEnumerable<IEnumerable<int>> dd = GetKCombs(new int[] { 1, 2, 3 }, 2);
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
            /*
            static IEnumerable<IEnumerable<T>> GetKCombs<T>(IEnumerable<T> list, int length) where T : IComparable
            {
                if (length == 1) return list.Select(t => new T[] { t });
                return GetKCombs(list, length - 1)
                    .SelectMany(t => list.Where(o => o.CompareTo(t.Last()) > 0),
                        (t1, t2) => t1.Concat(new T[] { t2 }));
            }
            */
            static void GetCombination(List<int> list ,int Base)
            {
                string combinations = "";
                double count = Math.Pow(2, list.Count);
                for (int i = 1; i <= count - 1; i++)
                {
                    string str = Convert.ToString(i, 2).PadLeft(list.Count, '0');
                    for (int j = 0; j < str.Length; j++)
                    {
                        if (str[j] == '1')
                        {
                            combinations = combinations + list[j];
                            //Console.Write(list[j]);
                        }
                    }
                    combinations = combinations + ",";
                    //Console.WriteLine();
                }
            }
        }
    }
}
