/*
 *
 *Arrays: Left Rotation
 * 
 * A left rotation operation on an array of size  shifts each of the array's elements  unit to the left. For example, if left rotations are performed on array , then the array would become .

Given an array of  integers and a number, , perform  left rotations on the array. Then print the updated array as a single line of space-separated integers.

Input Format

The first line contains two space-separated integers denoting the respective values of  (the number of integers) and  (the number of left rotations you must perform). 
The second line contains  space-separated integers describing the respective elements of the array's initial state.

Constraints

Output Format

Print a single line of  space-separated integers denoting the final state of the array after performing  left rotations.

Sample Input
5 4
1 2 3 4 5


Sample Output
5 1 2 3 4

*/


using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRank
{
    class Program1
    {
        static void Main1(String[] args)
        {
            string[] tokens_n = Console.ReadLine().Split(' ');
            int n = Convert.ToInt32(tokens_n[0]);
            int k = Convert.ToInt32(tokens_n[1]);
            string[] a_temp = Console.ReadLine().Split(' ');
            int[] a = Array.ConvertAll(a_temp, Int32.Parse);
            Queue<int> q = new Queue<int>(a);
            for (int i = 0; i < k; i++)
            {
                var top = (int)q.Dequeue();
                q.Enqueue(top);
            }
            StringBuilder sb = new StringBuilder();
            foreach (int element in q)
            {
                sb.Append($"{element} ");
            }
            sb.Remove(sb.Length - 1, 1);
            Console.Write(sb.ToString());
        }
    }
}
