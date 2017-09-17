using System;

namespace SolutionLoader
{
    class Program
    {
        static void Main(string[] args)
        {
            var watch = System.Diagnostics.Stopwatch.StartNew();
            var result = Problem2.SolveProblem();
            watch.Stop();

            Console.WriteLine($"{result} in {watch.ElapsedTicks} ticks");            
            Console.ReadLine();

        }
    }
}
