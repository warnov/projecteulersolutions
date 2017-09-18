using System;  // For prime 600851475143 + 6 = 600851475149 : 1.3 ms.


namespace SolutionLoader
{
    class Problem3b
    {
        internal static ulong SolveProblem()
        {
            ulong N = 600851475143;
            if (N <= 1) return 0;

            if (N % 2 == 0) { N /= 2; while (N % 2 == 0) N /= 2; if (N == 1) return 2; }
            if (N % 3 == 0) { N /= 3; while (N % 3 == 0) N /= 3; if (N == 1) return 3; }
            if (N % 5 == 0) { N /= 5; while (N % 5 == 0) N /= 5; if (N == 1) return 5; }

            uint d = 1, n = 0, rt = (uint)Math.Sqrt(N);

            if (N <= ~0u) { n = (uint)N; goto L1; }

            L0: d += 6; if (d > rt) return N;  // 7
            if (N % d == 0)
            {
                N /= d; while (N % d == 0) N /= d; if (N == 1) return d;
                rt = (uint)Math.Sqrt(N); if (N <= ~0u) { n = (uint)N; goto L2; }
            }
            d += 4; if (d > rt) return N;  // 11
            if (N % d == 0)
            {
                N /= d; while (N % d == 0) N /= d; if (N == 1) return d;
                rt = (uint)Math.Sqrt(N); if (N <= ~0u) { n = (uint)N; goto L3; }
            }
            d += 2; if (d > rt) return N;  // 13
            if (N % d == 0)
            {
                N /= d; while (N % d == 0) N /= d; if (N == 1) return d;
                rt = (uint)Math.Sqrt(N); if (N <= ~0u) { n = (uint)N; goto L4; }
            }
            d += 4; if (d > rt) return N;  // 17
            if (N % d == 0)
            {
                N /= d; while (N % d == 0) N /= d; if (N == 1) return d;
                rt = (uint)Math.Sqrt(N); if (N <= ~0u) { n = (uint)N; goto L5; }
            }
            d += 2; if (d > rt) return N;  // 19
            if (N % d == 0)
            {
                N /= d; while (N % d == 0) N /= d; if (N == 1) return d;
                rt = (uint)Math.Sqrt(N); if (N <= ~0u) { n = (uint)N; goto L6; }
            }
            d += 4; if (d > rt) return N;  // 23
            if (N % d == 0)
            {
                N /= d; while (N % d == 0) N /= d; if (N == 1) return d;
                rt = (uint)Math.Sqrt(N); if (N <= ~0u) { n = (uint)N; goto L7; }
            }
            d += 6; if (d > rt) return N;  // 29
            if (N % d == 0)
            {
                N /= d; while (N % d == 0) N /= d; if (N == 1) return d;
                rt = (uint)Math.Sqrt(N); if (N <= ~0u) { n = (uint)N; goto L8; }
            }
            d += 2; if (d > rt) return N;  // 31
            if (N % d == 0)
            {
                N /= d; while (N % d == 0) N /= d; if (N == 1) return d;
                rt = (uint)Math.Sqrt(N); if (N <= ~0u) { n = (uint)N; goto L1; }
            }
            goto L0;

            L1: d += 6; if (d > rt) return n;  //  7
            if (n % d == 0)
            { n /= d; while (n % d == 0) n /= d; if (n == 1) return d; rt = (uint)Math.Sqrt(n); }
            L2: d += 4; if (d > rt) return n;  // 11
            if (n % d == 0)
            { n /= d; while (n % d == 0) n /= d; if (n == 1) return d; rt = (uint)Math.Sqrt(n); }
            L3: d += 2; if (d > rt) return n;  // 13
            if (n % d == 0)
            { n /= d; while (n % d == 0) n /= d; if (n == 1) return d; rt = (uint)Math.Sqrt(n); }
            L4: d += 4; if (d > rt) return n;  // 17
            if (n % d == 0)
            { n /= d; while (n % d == 0) n /= d; if (n == 1) return d; rt = (uint)Math.Sqrt(n); }
            L5: d += 2; if (d > rt) return n;  // 19
            if (n % d == 0)
            { n /= d; while (n % d == 0) n /= d; if (n == 1) return d; rt = (uint)Math.Sqrt(n); }
            L6: d += 4; if (d > rt) return n;  // 23
            if (n % d == 0)
            { n /= d; while (n % d == 0) n /= d; if (n == 1) return d; rt = (uint)Math.Sqrt(n); }
            L7: d += 6; if (d > rt) return n;  // 29
            if (n % d == 0)
            { n /= d; while (n % d == 0) n /= d; if (n == 1) return d; rt = (uint)Math.Sqrt(n); }
            L8: d += 2; if (d > rt) return n;  // 31
            if (n % d == 0)
            { n /= d; while (n % d == 0) n /= d; if (n == 1) return d; rt = (uint)Math.Sqrt(n); }
            goto L1;
        }
    }
}