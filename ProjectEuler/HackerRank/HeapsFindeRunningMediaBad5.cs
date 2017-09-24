﻿/*
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


//Using a custom made container implementation (filling with ones the indexes of the given values in a 100000 array

using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace HackerRank
{
    class HeapFindRunningMediaOptimizedList
    {
        static void Main(String[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int[] a = new int[n];
            /*  for (int a_i = 0; a_i < n; a_i++)
              {
                  a[a_i] = Convert.ToInt32(Console.ReadLine());
              }*/

            var inputText = File.ReadAllText(@"c:\tmp\rm1000input.txt");
            var lines = inputText.Split("\n");
            for (int i = 0; i < n; i++)
            {
                a[i] = int.Parse(lines[i]);
            }

            var data = new List<int>();
            for (int i = 0; i < a.Length; i++)
            {
                var element = a[i];
                var median = InsertInMedianOptimizedList(element, data).ToString("F1");
                Console.WriteLine(median);
            }


            Console.ReadLine();
        }

        private static float InsertInMedianOptimizedList(int element, List<int> data)
        {
            var listCount = data.Count;
            switch (listCount)
            {
                case 0:
                    data.Add(element);
                    return element;
                case 1:
                    if (element < data[0])
                        data.Insert(0, element);
                    else data.Add(element);
                    return (float)(data[0] + data[1]) / 2;
                case 2:
                    if (element < data[0])
                        data.Insert(0, element);
                    else if (element < data[1])
                        data.Insert(1, element);
                    else data.Add(element);
                    return data[1];
                default:
                    int index;
                    var delta = listCount < 100 ? 5 : (int)(listCount * 0.5);
                    //odd
                    if (listCount % 2 != 0)
                    {
                        var centerIndex = listCount / 2;
                        var lowerBound = centerIndex - delta < 0 ? 0 : centerIndex - delta;
                        var lowerValue = data[lowerBound];
                        var upperBound = centerIndex + delta >= listCount ? listCount - 1 : centerIndex + delta;
                        var upperValue = data[upperBound];
                        var median = data[centerIndex];

                        if (element == median) index = centerIndex;

                        else if (element < median)
                        {
                            if (element < lowerValue) index = 0;
                            else
                            {
                                for (index = lowerBound; element >= data[index]; index++) ;
                            }
                        }
                        else
                        {
                            if (element > upperValue) index = listCount;
                            else
                            {
                                for (index = upperBound; element <= data[index]; index--) ;
                                index++;
                            }
                        }
                    }
                    else
                    {
                        var rightIndex = listCount / 2;
                        var leftIndex = rightIndex - 1;
                        var leftValue = data[leftIndex];
                        var rightValue = data[rightIndex];
                        var lowerBound = leftIndex - delta < 0 ? 0 : leftIndex - delta;
                        var lowerValue = data[lowerBound];
                        var upperBound = rightIndex + delta >= listCount ? listCount - 1 : rightIndex + delta;
                        var upperValue = data[upperBound];

                        if (element >= leftValue && element <= rightValue) index = rightIndex;
                        else if (element < leftValue)
                        {
                            if (element < lowerValue) index = 0;
                            else
                            {
                                for (index = lowerBound; element >= data[index]; index++) ;
                            }
                        }
                        else
                        {
                            if (element > upperValue) index = listCount;
                            else
                            {
                                for (index = upperBound; element <= data[index]; index--) ;
                                index++;
                            }
                        }
                    }
                    if (index >= listCount) data.Add(element);
                    else data.Insert(index, element);
                    return CalculateMedian(data);
            }
        }

        private static float CalculateMedian(List<int> items)
        {
            float ret = 0;
            var medIndx = (int)Math.Floor((double)(items.Count / 2));
            if (items.Count % 2 != 0)
            {
                ret = items[medIndx];
            }
            else
            {
                ret = (float)(items[medIndx - 1] + items[medIndx]) / 2;
            }
            return ret;
        }
    }
}
