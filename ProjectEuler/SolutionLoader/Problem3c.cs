using System;


namespace SolutionLoader
{
    internal class Problem3c
    {
        internal static ulong SolveProblem()
        {
            ulong n = 600851475143;
            if (n <= 1) return 0;
            if (n % 2 == 0) { n /= 2; while (n % 2 == 0) n /= 2; if (n == 1) return 2; }
            if (n % 3 == 0) { n /= 3; while (n % 3 == 0) n /= 3; if (n == 1) return 3; }
            if (n % 5 == 0) { n /= 5; while (n % 5 == 0) n /= 5; if (n == 1) return 5; }

            var b = new byte[] { 6, 4, 2, 4, 2, 4, 6, 2 }; int i = 8;
            uint d = 1, rt = (uint)Math.Sqrt(n);
            if (n <= ~0u) return gpf((uint)n, 1, rt, b, 8);

            for (; ; i = 0)
            {
                for (; i < 8; i++)
                {
                    d += b[i]; if (d > rt) return n;
                    if (n % d == 0)
                    {
                        n /= d; while (n % d == 0) n /= d;
                        if (n == 1) return d;
                        rt = (uint)Math.Sqrt(n);
                        if (n <= ~0u) return gpf((uint)n, d, rt, b, i + 1);
                    }
                }
                while (d + 30 < rt && n % (d + 06) > 0 && n % (d + 10) > 0
                                   && n % (d + 12) > 0 && n % (d + 16) > 0
                                   && n % (d + 18) > 0 && n % (d + 22) > 0
                                   && n % (d + 28) > 0 && n % (d + 30) > 0) d += 30;
            }
        }

        static uint gpf(uint n, uint d, uint rt, byte[] b, int i)
        {
            for (; ; i = 0)
            {
                for (; i < 8; i++)
                {
                    d += b[i]; if (d > rt) return n;
                    if (n % d == 0)
                    {
                        n /= d; while (n % d == 0) n /= d;
                        if (n == 1) return d;
                        rt = (uint)Math.Sqrt(n);
                    }
                }
                while (d + 30 < rt && n % (d + 06) > 0 && n % (d + 10) > 0
                                   && n % (d + 12) > 0 && n % (d + 16) > 0
                                   && n % (d + 18) > 0 && n % (d + 22) > 0
                                   && n % (d + 28) > 0 && n % (d + 30) > 0) d += 30;
            }
        }
    }
}
