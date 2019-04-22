using System;
using System.Collections.Generic;

namespace Work_Visitor
{
    class Program
    {
        static void Main(string[] args)
        {
            List<DaytimeWorker> daytimeWorkers = new List<DaytimeWorker>();
            List<NighttimeWorker> nighttimeWorkers= new List<NighttimeWorker>();

            //Create Raise, Visitor
            Raise bigRaise = new Raise(1.4);
            Raise smallRaise = new Raise(1.1);

            //Create Workers, Elements
            daytimeWorkers.Add(new DaytimeWorker("Jason",145));
            daytimeWorkers.Add(new DaytimeWorker("Jackson",147.5));
            daytimeWorkers.Add(new DaytimeWorker("Anders",150.5));
            nighttimeWorkers.Add(new NighttimeWorker("Jens",139.5));
            nighttimeWorkers.Add(new NighttimeWorker("Peter",145.5));
            nighttimeWorkers.Add(new NighttimeWorker("Hans",155.5));

            //Big Raise
            Console.WriteLine("\n*** Dayworkers after big raise ***");
            foreach (var dayWorker in daytimeWorkers)
            {
                dayWorker.Accept(bigRaise);
                Console.WriteLine();
            }

            //Small Raise
            Console.WriteLine("\n*** Nightworkers after small raise ***");
            foreach (var nightWorker in nighttimeWorkers)
            {
                nightWorker.Accept(smallRaise);
                Console.WriteLine();
            }
        }
    }
}
