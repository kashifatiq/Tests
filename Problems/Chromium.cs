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
                int[] leftSide;
                int[] rightSide;
                List<string> combinations = new List<string>();
                for (int pointer = 0; pointer < arrLenght; pointer++)
                {
                    
                    
                    CurrentNumber = H[pointer];
                    leftSide = SubArray(H, 0, pointer).Where(r => r >= H[pointer]).ToArray();
                    leftSide = leftSide.Where(r => r >= H[pointer]).ToArray();

                    rightSide = SubArray(H, pointer + 1, arrLenght - (pointer + 1));
                    rightSide = rightSide.Where(r => r >= H[pointer]).ToArray();

                    if (leftSide.Length == 0 && rightSide.Length == 0)
                    {
                        combinationCounts = combinationCounts + 1;
                    }
                    else if (leftSide.Length == 0 && rightSide.Length > 0)
                    {
                        combinationCounts = combinationCounts + rightSide.Length;
                    }
                    else if (leftSide.Length > 0 && rightSide.Length == 0)
                    {
                        combinationCounts = combinationCounts + leftSide.Length;
                    }
                }
                return combinationCounts;
            }

            public int[] SubArray(int[] data, int index, int length)
            {
                int[] result = new int[length];
                Array.Copy(data, index, result, 0, length);
                return result;
            }
        }
    }
}
