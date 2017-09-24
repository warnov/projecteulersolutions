using System;
using System.Collections.Generic;
using System.IO;

class Solution1 {
    /*
    * Complete the function below.
    */


    static int minimumNumberOfTrips(int tripMaxWeight, int[] packagesWeight)
    {
        var trips = new List<int>();
        var packagesList = new List<int>(packagesWeight);
        packagesList.Sort();

        return EvaluatePair(packagesList, tripMaxWeight);
    }

    private static int EvaluatePair(List<int> packagesList, int tripMaxWeight)
    {
        if (packagesList.Count >= 2)
        {
            var last = packagesList[packagesList.Count - 1];
            var first = packagesList[0];
            if (last + first <= tripMaxWeight)
            {
                packagesList.RemoveAt(0);
            }
            packagesList.RemoveAt(packagesList.Count - 1);
            return 1 + EvaluatePair(packagesList, tripMaxWeight);
        }
        else if (packagesList.Count == 1) return 1;
        else return 0;

    }

    // Input/Output code

    // The first line of the input contains two decimal integers separated by space:
    //   - the maximum weight ('W') that can be delivered in a single trip
    //   - the quantity of packages ('P') to be delivered.
    // The following 'P' lines contain a decimal integer representing the weight of each package.
    static void Main(string[] args)
    {
        string[] tokens = Console.ReadLine().Split();
        int tripMaxWeight = int.Parse(tokens[0]);
        int numberOfPackages = int.Parse(tokens[1]);

        int[] packagesWeight = new int[numberOfPackages];
        for (int i = 0; i < numberOfPackages; i++)
        {
            packagesWeight[i] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine(minimumNumberOfTrips(tripMaxWeight, packagesWeight));
        Console.ReadLine();
    }
}