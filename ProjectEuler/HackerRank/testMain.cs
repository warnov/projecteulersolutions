using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRank
{
    class testMain
    {
        static void MainTest()
        {
            /* //Testing LinkedList it is very expensive to make a sortedlinkelist, becaus it only
             //can be donde iterating from the first element
             LinkedList<int> data = new LinkedList<int>();
             Random rand = new Random(12345);
             for (int i = 0; i < 200000; i++)
             {
                 data.InsertSortedValue(rand.Next(300000));
             }
             var arrData = new int[data.Count];
             data.CopyTo(arrData, 0);
             foreach (int i in arrData) Console.WriteLine(i);
             */

            //Testing MinIntHeap
            //insertion is blazing fast but dont know how to traverse it
            MinIntHeap data = new MinIntHeap();
            Random rand = new Random(12345);
            var arrData = new int[40];
            for (int i = 0; i < 20; i++)
            {
                data.Add(rand.Next(30));
            }
            data.Backup();
            for (int i = 0; i < 20; i++)
            {
                arrData[i] = data.Poll();
                Console.Write(arrData[i] + " ");
            }
            data.Restore();
            for (int i = 0; i < 20; i++)
            {
                data.Add(rand.Next(30));
            }
            data.Backup();
            for (int i = 0; i < 40; i++)
            {
                arrData[i] = data.Poll();
            }

            /*
                        var maxSize = 100001;
                        var data = new int[maxSize];
                        Random rand = new Random(12345);
                        for (int i = 0; i < maxSize; i++)
                        {
                            var idx = rand.Next(0, maxSize);
                            data[idx]++;
                        }

                        var finalList = new List<int>();
                        int value;
                        for (int i = 0; i < maxSize; i++)
                        {
                            value = data[i];
                            if(value!=0)
                            {
                                for (int j = 0; j < value; j++)
                                {
                                    finalList.Add(i);
                                }
                            }
                        }*/

            //var arrData = finalList.ToArray();
            foreach (int i in arrData) Console.Write($"{i} ");
            Console.ReadLine();
        }
    }
}
