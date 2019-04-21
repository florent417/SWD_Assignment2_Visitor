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

            daytimeWorkers.Add(new DaytimeWorker("Jason",145));
            daytimeWorkers.Add(new DaytimeWorker("Jackson",147.5));
            daytimeWorkers.Add(new DaytimeWorker("Anders",150.5));

            nighttimeWorkers.Add(new NighttimeWorker("Jens",139.5));
            nighttimeWorkers.Add(new NighttimeWorker("Peter",145.5));
            nighttimeWorkers.Add(new NighttimeWorker("Hans",155.5));

            foreach (var dayWorker in daytimeWorkers)
            {
                dayWorker.Accept(new Raise());
                Console.WriteLine();
            }

            foreach (var nightWorker in nighttimeWorkers)
            {
                nightWorker.Accept(new Raise());
                Console.WriteLine();
            }
        }
    }
}
