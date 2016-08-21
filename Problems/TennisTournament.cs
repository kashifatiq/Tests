using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Problems
{
    public class TennisTournament
    {
        public int solution(int P, int C)
        {
            if (P < 0 || C < 0)
                return 0;
            int _results = 0;
            _results = (P / 2);
            if (_results > C)
                return C;
            else
                return _results;
        }
    }
}