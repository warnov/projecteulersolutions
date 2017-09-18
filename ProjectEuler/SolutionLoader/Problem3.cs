using System;
using System.Collections.Generic;
using System.Text;

namespace SolutionLoader
{
    internal class Problem3
    {
        internal static void SolveProblem()
        {
            long A = 600851475143;
            goto l2;


            l1:
            Console.Write("2 ");
            A /= 2;
            if (A == 1) goto l9;

            l2:
            if (A % 2 == 0) goto l1;
            var B = 3;

            l3:
            var C = Math.Sqrt(A) + 1;

            l4:
            if (B >= C) goto l8;
            if (A % B == 0) goto l6;

            l5:
            B += 2;
            goto l4;

            l6:
            if (A / B * B - A == 0) goto l7;
            goto l5;

            l7:
            Console.Write($"{B} ");
            A /= B;
            goto l3;

            l8:
            Console.Write($"{A} ");

            l9:
            Console.WriteLine("END");
        }
    }
}
