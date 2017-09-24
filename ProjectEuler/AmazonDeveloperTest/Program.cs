using System;
using System.Collections.Generic;
using System.IO;

class Solution
{

    private class Drone
    {
        public int Id { get; set; }
        public int FlightRange { get; set; }
    }
    /*
    * Complete the function below.
    */
    static List<int> GreatestFlightRangeDrones(int requiredDrones, List<Drone> drones, List<int> inMaintenanceDrones)
    {

        foreach (var id in inMaintenanceDrones)
        {
            var idx = drones.FindIndex(x => x.Id == id);
            drones.RemoveAt(idx);
        }


        drones.Sort(
            (x, y) =>
            {
                IComparable comparable = x.FlightRange as IComparable;
                if (comparable != null)
                {
                    return -1 * comparable.CompareTo(y.FlightRange);
                }
                return 0;
            });

        var ret = new List<int>();     
        for (int i = 0; i < requiredDrones; i++)
        {
            ret.Add(drones[i].Id);
        }
        return ret;
    }

    // Input/Output code

    // The first line of the input contains three decimal ints separated by space:
    //   - total number of drones ('D')
    //   - number of drones to be selected ('G')
    //   - number of drones in maintenance ('M')
    // The following 'D' lines each contains two decimal ints separated by space with information about each drone:
    //   - ID
    //   - flight range in kilometers
    // The following 'M' lines each contains the numeric ID of a drone currently in maintenance.

    // Print the IDs of the 'G' selected drones to the standard output, one per line, sorted by flight range (greater first).
    static void pMain(String[] args)
    {
        string[] tokens = Console.ReadLine().Split();
        int numberOfDrones = int.Parse(tokens[0]);
        int requiredDrones = int.Parse(tokens[1]);
        int numberOfDronesInMaintenance = int.Parse(tokens[2]);

        var drones = new List<Drone>();
        var inMaintenanceDrones = new List<int>();

        for (int i = 0; i < numberOfDrones; i++)
        {
            tokens = Console.ReadLine().Split();
            drones.Add(new Drone { Id = int.Parse(tokens[0]), FlightRange = int.Parse(tokens[1]) });
        }

        for (int i = 0; i < numberOfDronesInMaintenance; i++)
        {
            inMaintenanceDrones.Add(int.Parse(Console.ReadLine()));
        }

        var result = GreatestFlightRangeDrones(requiredDrones, drones, inMaintenanceDrones);

        foreach (var droneId in result)
        {
            Console.WriteLine(droneId);
        }
    }

}