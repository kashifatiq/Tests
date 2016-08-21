using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
public class Solution
{
    public int BiggestPair = 0;
    public int solution(string S, int K)
    {
        PairResults _results = new PairResults();
        StringBuilder strAfterRotation = new StringBuilder(S);
        for (int x = 0; x < K; x++)
        {
            _results = findLongestPairs(strAfterRotation.ToString());
            BiggestPair = Math.Max(BiggestPair, _results.PairCount);
            if (_results.RemainingStack.Count() <= 1) // there are no brackets remaining to rotate 
                break;
            else // there are some brackets still remaining to rotate
            {
                // we can rotate remaining brackets
                Stack<int> dummyStack = _results.RemainingStack;
                char charToRotate = S[dummyStack.Peek()];
                char rotatedChar;
                if (charToRotate == '(')
                    rotatedChar = ')';
                else
                    rotatedChar = '(';
                strAfterRotation[dummyStack.Peek()] = rotatedChar;
                K = K - 1;
                solution(strAfterRotation.ToString(), K);
            }
        }
        return BiggestPair;
    }

    public PairResults findLongestPairs(string str)
    {
        int n = str.Count();

        // Create a stack and push -1 as initial index to it.
        var stk = new Stack<int>();
        stk.Push(-1);

        // Initialize result
        int result = 0;

        // Traverse all characters of given string
        for (int i = 0; i < n; i++)
        {
            // If opening bracket, push index of it
            if (str[i] == '(')
                stk.Push(i);

            else // If closing bracket, i.e.,str[i] = ')'
            {
                // Pop the previous opening bracket's index
                stk.Pop();

                // Check if this length formed with base of
                // current valid substring is more than max 
                // so far
                if (stk.Count != 0)
                    result = Math.Max(result, i - stk.Peek());

                // If stack is empty. push current index as 
                // base for next valid substring (if any)
                else stk.Push(i);
            }
        }

        PairResults PairResult = new PairResults();
        PairResult.PairCount = result;
        PairResult.RemainingStack = stk;
        return PairResult;
    }
}

public class PairResults
{
    public int PairCount { get; set; }
    public Stack<int> RemainingStack { get; set; }
}