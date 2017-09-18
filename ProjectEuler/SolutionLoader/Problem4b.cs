using System;
using System.Collections.Generic;
using System.Text;

namespace SolutionLoader
{
    internal class Problem4b
    {
        //average 115ms.
        static internal int SolveProblem()
        {
            int sum;
            int Largest = -1;
            string res;
            bool Palindrome = true;

            for (int x = 999; x >= 1; x--)
            {
                for (int y = 999; y >= 1; y--)
                {
                    sum = x * y;
                    res = sum.ToString();
                    Palindrome = true;
                    for (int t = 0; t < res.Length / 2; t++)
                    {
                        if (res[t] != res[res.Length - t - 1]) Palindrome = false;
                    }
                    if (Palindrome) if (sum > Largest) Largest = sum;
                }
            }
            return Largest;
        }
    }
}
