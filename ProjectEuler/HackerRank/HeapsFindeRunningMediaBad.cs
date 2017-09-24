/*
 * The median of a dataset of integers is the midpoint value of the dataset for which an equal number of integers are less than and greater than the value. To find the median, you must first sort your dataset of integers in non-decreasing order, then:

If your dataset contains an odd number of elements, the median is the middle element of the sorted sample. In the sorted dataset ,  is the median.
If your dataset contains an even number of elements, the median is the average of the two middle elements of the sorted sample. In the sorted dataset ,  is the median.
Given an input stream of  integers, you must perform the following task for each  integer:

Add the  integer to a running list of integers.
Find the median of the updated list (i.e., for the first element through the  element).
Print the list's updated median on a new line. The printed value must be a double-precision number scaled to  decimal place (i.e.,  format).
Input Format

The first line contains a single integer, , denoting the number of integers in the data stream. 
Each line  of the  subsequent lines contains an integer, , to be added to your list.

Constraints

Output Format

After each new integer is added to the list, print the list's updated median on a new line as a single double-precision number scaled to  decimal place (i.e.,  format).

Sample Input

6
12
4
5
3
8
7
Sample Output

12.0
8.0
5.0
4.5
5.0
6.0
Explanation

There are  integers, so we must print the new median on a new line as each integer is added to the list:
*/
using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRank
{
    class HeapsFindRunningMedia
    {
        static void MainBad(String[] args)  //Lists too slow to sort with thousands of elements
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int[] a = new int[n];
            for (int a_i = 0; a_i < n; a_i++)
            {
                a[a_i] = Convert.ToInt32(Console.ReadLine());
            }

            var heap = new List<int>();
            foreach (var element in a)
            {
                heap.Add(element);
                heap.Sort();
                Console.WriteLine(CalculateMedia(heap).ToString("F1"));
            }




            Console.ReadLine();
        }

        private static float CalculateMedia(List<int> heap)
        {
            float ret = 0;
            var medIndx = (int)Math.Floor((double)(heap.Count / 2));
            if (heap.Count % 2 != 0)
            {
                ret = heap[medIndx];
            }
            else
            {
                ret = (float)(heap[medIndx-1] + heap[medIndx]) / 2;
            }
            return ret;
        }
    }
}
