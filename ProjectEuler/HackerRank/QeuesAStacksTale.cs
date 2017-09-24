using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRank
{
    class Solution
    {
        static void Main5(String[] args)
        {
            var queriesAmount = int.Parse(Console.ReadLine());
            Queue<int> q = new Queue<int>();
            List<string> queries = new List<string>();
            for (int i = 0; i < queriesAmount; i++)
            {
                queries.Add(Console.ReadLine());
            }

            foreach (var query in queries)
            {
                var components = query.Split(" ");
                var command = int.Parse(components[0]);
                switch (command)
                {
                    case 1:
                        var element = int.Parse(components[1]);
                        q.Enqueue(element);
                        break;
                    case 2:
                        q.Dequeue();
                        break;
                    case 3:
                        Console.WriteLine(q.Peek());
                        break;
                }
            }

            Console.ReadLine();
        }
    }
}
