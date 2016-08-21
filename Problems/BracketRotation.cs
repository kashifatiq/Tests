using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Problems
{
    public class BracketRotation
    {
        private bool isValidPair(char left, char right)
        {
            if (left == '(' && right == ')')
                return true;
            return false;
        }

        public QuestionResults solution(string S)
        {
            QuestionResults results = new QuestionResults();
            int consecutivePairsCounter = 0;
            int longestPair = 0;
            var stack = new Stack<char>();
            foreach (char symbol in S)
            {
                if (symbol == '(')
                {
                    stack.Push(symbol);
                    if (consecutivePairsCounter > results.consecutivePairsCount)
                    { 
                        results.consecutivePairsCount = consecutivePairsCounter; 
                    }
                    consecutivePairsCounter = 0;
                }
                else
                {
                    if (stack.Count == 0)
                    {
                        results.isCompleteValid = false;
                        return results;
                    }
                    char last = stack.Pop();
                    if (!isValidPair(last, symbol))
                    {
                        results.isCompleteValid = false;
                        return results;
                    }
                    else
                    {
                        consecutivePairsCounter = consecutivePairsCounter + 1;
                    }
                }
            }
            if (stack.Count() != 0)
            {
                results.isCompleteValid = false;
            }
            else
            {
                results.isCompleteValid = true;
            }
            //results.consecutivePairsCount = consecutivePairsCounter;
            return results;
        }

        public int BiggestPair = 0;

        public int solution(string S, int K)
        {
            PairResults _results = new PairResults();
            //int PairLenght = 0;
            StringBuilder strAfterRotation = new StringBuilder(S);
            //int BiggestPair = 0;
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

    public class QuestionResults
    {
        public bool isCompleteValid { get; set; }
        public int consecutivePairsCount { get; set; }
    }
}
