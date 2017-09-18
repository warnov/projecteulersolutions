using System;
using System.Collections.Generic;
using System.Text;

namespace SolutionLoader
{
    internal class Problem2b
    {
        internal static long SolveProblem()
        {
            long sum = 0, i0, i1 = 1, i2 = 2;
            do
            {
                sum += i2;
                for (int i = 0; i < 3; i++)
                {
                    i0 = i1;
                    i1 = i2;
                    i2 = i1 + i0;
                }
            } while (i2 < 4000000000);
            return sum;
        }
    }
}
