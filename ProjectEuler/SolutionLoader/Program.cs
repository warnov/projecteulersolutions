using System;

namespace SolutionLoader
{
    class Program
    {
        static void Main(string[] args)
        {
            var watch = System.Diagnostics.Stopwatch.StartNew();
            var result = Problem4.SolveProblem();
            //var result = Problem2b.SolveProblem();
            //Problem3.SolveProblem();
            //var result = Problem3c.SolveProblem();
            watch.Stop();

            //Console.WriteLine($"{result} in {watch.ElapsedTicks} ticks");            
            //Console.WriteLine($"Result in {watch.ElapsedTicks} ticks or {watch.ElapsedMilliseconds} ms.");
            Console.WriteLine($"{result} in {watch.ElapsedTicks} ticks or {watch.ElapsedMilliseconds} ms.");

            Console.ReadLine();
                
        }
    }
}
