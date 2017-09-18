using System;
using System.Collections.Generic;
using System.Text;

namespace SolutionLoader
{
    //<1ms average
    internal class Problem4
    {
        internal static uint SolveProblem()
        {
            uint factor = 0;
           
            uint max = 0;

            for (uint i = 999 ; i > 0; i--)
            {
                for (uint j = 999; j > 0; j--)
                {
                    factor = i * j;
                    if (factor < max) break;
                    string sFactor = factor.ToString();
                    if (Palindromic(sFactor))
                    {                       
                        if (factor > max) max = factor;
                        break;
                    }
                }                
            }           
            return max;
        }        

        private static bool Palindromic(string sFactor)
        {
            if (sFactor.Length <= 1)
                return true;
            else
            {
                if (sFactor[0] == sFactor[sFactor.Length - 1])
                {
                    var newSFactor = sFactor.Remove(0, 1);
                    newSFactor = newSFactor.Remove(newSFactor.Length - 1, 1);
                    return Palindromic(newSFactor);
                }
                return false;
            }
        }
    }
}
