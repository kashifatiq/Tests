using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Problems
{
    /// <summary>
    /// C = clean socks
    /// D = dirty socks
    /// K = number of socks washing machine can wash in a single go like K = 2 socks
    /// For example, given 
    /// K = 2, 
    /// C = [1, 2, 1, 1] 
    /// D = [1, 4, 3, 2, 4], the function should return 3
    /// 
    /// C = [1,1,1,2] sorted
    /// 
    /// </summary>
    public class SocksSupply
    {
        public int solution(int K, int[] C, int[] D)
        {
            int __results = 0;
            var sortedC = C.OrderBy(x => x).ToList();
            for(int counter = 0;counter<=K;counter++)
            {
                
            }
            return __results;
        }
    }
}
